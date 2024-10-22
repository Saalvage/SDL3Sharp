// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS9084 // Struct member returns 'this' or other instance members by reference

namespace SDL3Sharp
{
    public enum SensorType
    {
        /// <summary>Returned for an invalid sensor</summary>
        Invalid = -1,
        /// <summary>Unknown sensor type</summary>
        Unknown = 0,
        /// <summary>Accelerometer</summary>
        Accel = 1,
        /// <summary>Gyroscope</summary>
        Gyro = 2,
        /// <summary>Accelerometer for left Joy-Con controller and Wii nunchuk</summary>
        AccelL = 3,
        /// <summary>Gyroscope for left Joy-Con controller</summary>
        GyroL = 4,
        /// <summary>Accelerometer for right Joy-Con controller</summary>
        AccelR = 5,
        /// <summary>Gyroscope for right Joy-Con controller</summary>
        GyroR = 6
    }

    /// <summary>
    /// <para>This is a unique ID for a sensor for the time it is connected to the system,</para>
    /// <para>and is never reused for the lifetime of the application.</para>
    /// </summary>
    /// <remarks>The ID value starts at 1 and increments from there. The value 0 is an invalid ID.</remarks>
    /// <summary>SDL_sensor.h</summary>
    /// <remarks>
    /// <para>In order to use these functions, SDL_Init() must have been called</para>
    /// <para>with the ::SDL_INIT_SENSOR flag.  This causes SDL to scan the system</para>
    /// <para>for sensors, and load appropriate drivers.</para>
    /// </remarks>
    public unsafe partial class Sensor
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Sensor> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Sensor>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::SDL3Sharp.Sensor managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::SDL3Sharp.Sensor managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Sensor __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Sensor(native.ToPointer(), skipVTables);
        }

        internal static Sensor __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Sensor)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Sensor __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Sensor(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Sensor(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Sensor(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensors", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint* GetSensors(int* count);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorInstanceName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetSensorInstanceName(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorInstanceType", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::SDL3Sharp.SensorType GetSensorInstanceType(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorInstanceNonPortableType", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSensorInstanceNonPortableType(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_OpenSensor", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr OpenSensor(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorFromInstanceID", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetSensorFromInstanceID(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorProperties", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetSensorProperties(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetSensorName(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorType", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::SDL3Sharp.SensorType GetSensorType(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorNonPortableType", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSensorNonPortableType(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorInstanceID", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetSensorInstanceID(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetSensorData", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSensorData(__IntPtr sensor, float* data, int num_values);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_CloseSensor", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void CloseSensor(__IntPtr sensor);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_UpdateSensors", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void UpdateSensors();
        }

        /// <summary>Get a list of currently connected sensors.</summary>
        /// <param name="count">a pointer filled in with the number of sensors returned</param>
        /// <remarks>
        /// <para>a 0 terminated array of sensor instance IDs which should be freed</para>
        /// <para>with SDL_free(), or NULL on error; call SDL_GetError() for more</para>
        /// <para>details.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static uint* GetSensors(ref int count)
        {
            fixed (int* __count0 = &count)
            {
                var __arg0 = __count0;
                var ___ret = __Internal.GetSensors(__arg0);
                return ___ret;
            }
        }

        /// <summary>Get the implementation dependent name of a sensor.</summary>
        /// <param name="instance_id">the sensor instance ID</param>
        /// <remarks>
        /// <para>the sensor name, or NULL if `instance_id` is not valid</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static string GetSensorInstanceName(uint instance_id)
        {
            var ___ret = __Internal.GetSensorInstanceName(instance_id);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Get the type of a sensor.</summary>
        /// <param name="instance_id">the sensor instance ID</param>
        /// <remarks>
        /// <para>the SDL_SensorType, or `SDL_SENSOR_INVALID` if `instance_id` is</para>
        /// <para>not valid</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static global::SDL3Sharp.SensorType GetSensorInstanceType(uint instance_id)
        {
            var ___ret = __Internal.GetSensorInstanceType(instance_id);
            return ___ret;
        }

        /// <summary>Get the platform dependent type of a sensor.</summary>
        /// <param name="instance_id">the sensor instance ID</param>
        /// <remarks>
        /// <para>the sensor platform dependent type, or -1 if `instance_id` is not</para>
        /// <para>valid</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static int GetSensorInstanceNonPortableType(uint instance_id)
        {
            var ___ret = __Internal.GetSensorInstanceNonPortableType(instance_id);
            return ___ret;
        }

        /// <summary>Open a sensor for use.</summary>
        /// <param name="instance_id">the sensor instance ID</param>
        /// <remarks>
        /// <para>an SDL_Sensor sensor object, or NULL if an error occurred.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static global::SDL3Sharp.Sensor OpenSensor(uint instance_id)
        {
            var ___ret = __Internal.OpenSensor(instance_id);
            var __result0 = global::SDL3Sharp.Sensor.__GetOrCreateInstance(___ret, false);
            return __result0;
        }

        /// <summary>Return the SDL_Sensor associated with an instance ID.</summary>
        /// <param name="instance_id">the sensor instance ID</param>
        /// <remarks>
        /// <para>an SDL_Sensor object.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static global::SDL3Sharp.Sensor GetSensorFromInstanceID(uint instance_id)
        {
            var ___ret = __Internal.GetSensorFromInstanceID(instance_id);
            var __result0 = global::SDL3Sharp.Sensor.__GetOrCreateInstance(___ret, false);
            return __result0;
        }

        /// <summary>Get the properties associated with a sensor.</summary>
        /// <param name="sensor">The SDL_Sensor object</param>
        /// <remarks>
        /// <para>a valid property ID on success or 0 on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetProperty</para>
        /// <para>SDL_SetProperty</para>
        /// </remarks>
        public static uint GetSensorProperties(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            var ___ret = __Internal.GetSensorProperties(__arg0);
            return ___ret;
        }

        /// <summary>Get the implementation dependent name of a sensor</summary>
        /// <param name="sensor">The SDL_Sensor object</param>
        /// <remarks>
        /// <para>the sensor name, or NULL if `sensor` is NULL.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static string GetSensorName(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            var ___ret = __Internal.GetSensorName(__arg0);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Get the type of a sensor.</summary>
        /// <param name="sensor">The SDL_Sensor object to inspect</param>
        /// <remarks>
        /// <para>the SDL_SensorType type, or `SDL_SENSOR_INVALID` if `sensor` is</para>
        /// <para>NULL.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static global::SDL3Sharp.SensorType GetSensorType(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            var ___ret = __Internal.GetSensorType(__arg0);
            return ___ret;
        }

        /// <summary>Get the platform dependent type of a sensor.</summary>
        /// <param name="sensor">The SDL_Sensor object to inspect</param>
        /// <remarks>
        /// <para>the sensor platform dependent type, or -1 if `sensor` is NULL.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static int GetSensorNonPortableType(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            var ___ret = __Internal.GetSensorNonPortableType(__arg0);
            return ___ret;
        }

        /// <summary>Get the instance ID of a sensor.</summary>
        /// <param name="sensor">The SDL_Sensor object to inspect</param>
        /// <remarks>
        /// <para>the sensor instance ID, or 0 if `sensor` is NULL.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static uint GetSensorInstanceID(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            var ___ret = __Internal.GetSensorInstanceID(__arg0);
            return ___ret;
        }

        /// <summary>Get the current state of an opened sensor.</summary>
        /// <param name="sensor">The SDL_Sensor object to query</param>
        /// <param name="data">A pointer filled with the current sensor state</param>
        /// <param name="num_values">The number of values to write to data</param>
        /// <remarks>
        /// <para>The number of values and interpretation of the data is sensor dependent.</para>
        /// <para>0 on success or a negative error code on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static int GetSensorData(global::SDL3Sharp.Sensor sensor, ref float data, int num_values)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            fixed (float* __data1 = &data)
            {
                var __arg1 = __data1;
                var ___ret = __Internal.GetSensorData(__arg0, __arg1, num_values);
                return ___ret;
            }
        }

        /// <summary>Close a sensor previously opened with SDL_OpenSensor().</summary>
        /// <param name="sensor">The SDL_Sensor object to close</param>
        /// <remarks>This function is available since SDL 3.0.0.</remarks>
        public static void CloseSensor(global::SDL3Sharp.Sensor sensor)
        {
            var __arg0 = sensor is null ? __IntPtr.Zero : sensor.__Instance;
            __Internal.CloseSensor(__arg0);
        }

        /// <summary>Update the current state of the open sensors.</summary>
        /// <remarks>
        /// <para>This is called automatically by the event loop if sensor events are</para>
        /// <para>enabled.</para>
        /// <para>This needs to be called from the thread that initialized the sensor</para>
        /// <para>subsystem.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static void UpdateSensors()
        {
            __Internal.UpdateSensors();
        }
    }
}
