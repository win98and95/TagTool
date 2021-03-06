using TagTool.Cache;
using TagTool.Common;
using System;
using System.Collections.Generic;
using TagTool.Audio;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "sound", Tag = "snd!", Size = 0x20, MaxVersion = CacheVersion.Halo3ODST)]
	[TagStructure(Name = "sound", Tag = "snd!", Size = 0xD4, MinVersion = CacheVersion.HaloOnline106708, MaxVersion = CacheVersion.HaloOnline235640)]
	[TagStructure(Name = "sound", Tag = "snd!", Size = 0xD8, MinVersion = CacheVersion.HaloOnline301003, MaxVersion = CacheVersion.HaloOnline449175)]
	[TagStructure(Name = "sound", Tag = "snd!", Size = 0x20, MinVersion = CacheVersion.HaloReach)]
    public class Sound : TagStructure
	{
        public FlagsValue Flags;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public short Unknown1;
        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public uint Unknown2;
        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public uint Unknown3;
        
        public SoundClass SoundClass;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public SampleRate SampleRate;

        [TagField(MaxVersion = CacheVersion.Halo3ODST)]
        public SoundCacheFileGestaltReference SoundReference;
        
        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public byte Unknown6;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public ImportType ImportType;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public PlaybackParameter PlaybackParameters;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public Scale Scale;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public PlatformCodec PlatformCodec;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public Promotion Promotion;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public List<PitchRange> PitchRanges;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public List<CustomPlayback> CustomPlayBacks;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public List<ExtraInfo> ExtraInfo;

        [TagField(MinVersion = CacheVersion.HaloOnline106708)]
        public List<LanguageBlock> Languages;

        [TagField(Flags = TagFieldFlags.Pointer, MinVersion = CacheVersion.HaloOnline106708)]
        public PageableResource Resource;
        
        [TagField(Flags = TagFieldFlags.Padding, Length = 4, MinVersion = CacheVersion.HaloOnline106708)]
        public byte[] Unused;

        [TagField(MinVersion = CacheVersion.HaloOnline301003, MaxVersion = CacheVersion.HaloOnline449175)]
        public uint Unknown12;
        
        [Flags]
        public enum FlagsValue : ushort
        {
            None = 0,
            LoopingSound = 1 << 0,
            SplitLongSoundIntoPermutations  = 1 << 1
        }

        [TagStructure(Size = 0x1D)]
        public class SoundCacheFileGestaltReference : TagStructure
		{
            public byte PitchRangeCount;
            public short PlatformCodecIndex;
            public short PitchRangeIndex;
            public short LanguageIndex;
            public short Unknown4;
            public short PlaybackParameterIndex;
            public short ScaleIndex;
            public sbyte PromotionIndex;
            public sbyte CustomPlaybackIndex;
            public short ExtraInfoIndex;
            public int LongestPermutationDurationMs;

            public int ZoneAssetHandle;
            [TagField(Flags = TagFieldFlags.Padding, Length = 4)]
            public byte[] Unused;
        }

    }
}