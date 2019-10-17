using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.WebRTC.Interop
{
    internal class AudioReadStreamInterop
    {
        [DllImport(Utils.dllPath, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi,
            EntryPoint = "mrsAudioReadStreamCreate")]
        public static extern void Create(IntPtr peerHandle, int bufferMs, ref IntPtr audioReadStream);

        [DllImport(Utils.dllPath, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi,
            EntryPoint = "mrsAudioReadStreamRead")]
        public static extern void Read(IntPtr audioReadStream, int sampleRate, float[] data, int dataLen, int numChannels);

        [DllImport(Utils.dllPath, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi,
            EntryPoint = "mrsAudioReadStreamDestroy")]
        public static extern void Destroy(IntPtr audioReadStream);
    }
}