using SDL3Sharp;

SDL.Init(InitFlags.Video);

SDL.CreateWindow("SDL3 in C#!", 250, 250, WindowFlags.AlwaysOnTop);

while (true) {
    SDL.PollEvent(out _);
}
