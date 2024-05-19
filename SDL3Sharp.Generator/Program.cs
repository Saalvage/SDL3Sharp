using System.Text;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Generators.CSharp;
using CppSharp.Passes;
using CppSharp.Types;
using Type = CppSharp.AST.Type;

ConsoleDriver.Run(new SDL3SharpLibrary());

public class SDL3SharpLibrary : ILibrary {
    public void Setup(Driver driver) {
        var options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;

        var rootDir = Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../../");
        var genDir = rootDir + "SDL3Sharp.Generator/";
        var outDir = rootDir + "SDL3Sharp/Source";
        foreach (var file in Directory.EnumerateFiles(outDir)) {
            File.Delete(file);
        }

        var libDir = rootDir + "Libraries/";

        var sdlInclude = libDir + "SDL/include/";
        var sdlInclude3 = sdlInclude + "SDL3/";

        var includeStubs = genDir + "IncludeStubs/";

        var module = options.AddModule("SDL3Sharp");
        module.IncludeDirs.Add(includeStubs);
        module.IncludeDirs.Add(sdlInclude);
        module.Headers.Add(sdlInclude3 + "SDL.h");
        module.Headers.Add(sdlInclude3 + "SDL_video.h");
        module.Headers.Add(sdlInclude3 + "SDL_version.h");

        module.Defines.Add("SDL_ENABLE_SYSWM_WINDOWS");
        module.Defines.Add("SDL_ENABLE_SYSWM_WINRT");
        module.Defines.Add("SDL_ENABLE_SYSWM_X11");
        module.Defines.Add("SDL_ENABLE_SYSWM_COCOA");
        module.Defines.Add("SDL_ENABLE_SYSWM_UIKIT");
        module.Defines.Add("SDL_ENABLE_SYSWM_WAYLAND");
        module.Defines.Add("SDL_ENABLE_SYSWM_ANDROID");
        module.Defines.Add("SDL_ENABLE_SYSWM_VIVANTE");
        module.Defines.Add("SDL_ENABLE_SYSWM_KMSDRM");

        module.Defines.Add("SDL_DISABLE_SYSWM_VIVANTE_TYPES");
        module.Defines.Add("SDL_DISABLE_SYSWM_COCOA_TYPES");
        module.Defines.Add("SDL_DISABLE_SYSWM_UIKIT_TYPES");
        module.Defines.Add("SDL_DISABLE_SYSWM_ANDROID_TYPES");

        options.NoGenIncludeDirs ??= [];
        options.NoGenIncludeDirs.Add(includeStubs);

        options.OutputDir = outDir;

        options.GenerateFreeStandingFunctionsClassName = _ => "SDL";
        options.GenerationOutputMode = GenerationOutputMode.FilePerUnit;
    }

    public void SetupPasses(Driver driver) {
        driver.Context.TranslationUnitPasses.RemovePrefix("SDL_");

        driver.SetupTypeMaps();
    }

    public void Preprocess(Driver driver, ASTContext ctx) {
        ctx.IgnoreHeadersWithName("windows.h");
        ctx.IgnoreHeadersWithName("Inspectable.h");
        ctx.IgnoreHeadersWithName("X11/Xlib.h");
        ctx.IgnoreHeadersWithName("X11/Xatom.h");

        var windowFlags = ctx.GenerateEnumFromMacros("WindowFlags", "SDL_WINDOW_(.*)")
            .SetFlags();
        WindowFlagsMap.EnumType = new TagType(windowFlags);

        ctx.ReplaceParameterWithEnum("SDL_Init", "flags", ctx.FindTypedef("SDL_InitFlags").Single().Type);

        ctx.FindFunction("SDL_GetWindowFlags").Single().ReturnType =
            ctx.FindTypedef("SDL_WindowFlags").Single().QualifiedType;

        // TODO: This is complicated, we currently seem to be unable to modify the Type member of the generated internal type.
        // ctx.FindClass("SDL_Event").Single().Fields.First(x => x.Name == "type").QualifiedType = new(new TagType(ctx.FindEnum("SDL_EventType").Single()));

        ctx.SetFunctionParameterUsage("SDL_PollEvent", 1, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetVersion", 1, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowWMInfo", 2, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowOpacity", 2, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowPosition", 2, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowPosition", 3, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowSize", 2, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetWindowSize", 3, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GL_GetAttribute", 2, ParameterUsage.Out);
        ctx.SetFunctionParameterUsage("SDL_GetJoysticks", 1, ParameterUsage.Out);

        ctx.SetClassAsValueType("SDL_Point");

        ctx.SetEnumAsFlags("SDL_WindowFlags");
        ctx.SetEnumAsFlags("SDL_Keymod"); // TODO: This has dead giveaways for being a flags enum! (Order has to be considered, first PO2 then masks)

        ctx.GenerateEnumFromMacros("MouseButton", "SDL_BUTTON_(.*)");

        foreach (var e in ctx.TranslationUnits
                     .SelectMany(x => x.Declarations, (_, d) => d as Enumeration)
                     .Where(x => x != null)) {
            var commonPrefix = LongestCommonPrefix(e.Items.Select(x => x.Name).ToArray());
            foreach (var val in e.Items) {
                val.Name = val.Name.Replace(commonPrefix, "");
                val.Name = ScreamingSnakeToUpperCamel(val.Name);
            }
        }

        string ScreamingSnakeToUpperCamel(string screaming) {
            var nextCapital = true;
            var sb = new StringBuilder();
            sb.Capacity = screaming.Length;
            for (var i = 0; i < screaming.Length; i++) {
                if (screaming[i] == '_') {
                    nextCapital = true;
                    continue;
                }

                sb.Append(nextCapital ? char.ToUpper(screaming[i]) : char.ToLower(screaming[i]));
                nextCapital = false;
            }

            return sb.ToString();
        }

        string LongestCommonPrefix(string[] strings) {
            if (strings.Length == 0) {
                return "";
            }

            for (var i = 0; i < strings[0].Length; i++) {
                if (strings.Any(x => x.Length <= i || x[i] != strings[0][i])) {
                    return strings[0][..i];
                }
            }

            return strings[0];
        }
    }

    public void Postprocess(Driver driver, ASTContext ctx) {
        ctx.RenameNamespace("SDL3", "SDL3Sharp");
        foreach (var i in ctx.TranslationUnits) {
            if (i.Module != null) {
                i.Module.SharedLibraryName = "SDL3";
            }
        }
    }
}

[TypeMap("SDL_WindowFlags")]
public class WindowFlagsMap : TypeMap {
    public static TagType EnumType;

    public override Type SignatureType(TypePrinterContext ctx) => EnumType;
}

[TypeMap("SDL_bool")]
public class BoolMap : TypeMap {
    public override Type SignatureType(TypePrinterContext ctx) => new CILType(typeof(bool));
}

[TypeMap("Uint32")]
public class UInt32Map : TypeMap {
    public static Dictionary<Parameter, Type> Parameters { get; } = [];

    public override Type SignatureType(TypePrinterContext ctx)
        => ctx.Parameter != null && Parameters.TryGetValue(ctx.Parameter, out var type)
            ? type
            : CSharpTypePrinter.GetUnsignedType(32);

    public override void MarshalToNative(MarshalContext ctx) {
        if (ctx.Parameter != null && Parameters.ContainsKey(ctx.Parameter)) {
            ctx.Return.Write("(uint)" + ctx.Parameter.Name);
        } else {
            base.MarshalToNative(ctx);
        }
    }
}

[TypeMap("wl_display")]
[TypeMap("wl_surface")]
[TypeMap("wl_egl_window")]
[TypeMap("xdg_surface")]
[TypeMap("xdg_toplevel")]
[TypeMap("xdg_popup")]
[TypeMap("xdg_positioner")]
[TypeMap("gbm_device")]
public class DisplayMap : TypeMap {
    public override Type SignatureType(TypePrinterContext ctx) => new CILType(typeof(IntPtr));
}

static class Extensions {
    public static void ReplaceParameterWithEnum(this ASTContext ctx, string functionName, string parameterName, Type enumType) {
        var parameters = ctx.FindFunction(functionName).Single().Parameters;
        UInt32Map.Parameters.Add(parameters.First(x => x.Name == parameterName), enumType);
    }
}
