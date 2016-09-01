#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioClip
struct AudioClip_t3714538611;

#include "mscorlib_System_ValueType4014882752.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GuitarNoteClips/AudioClips
struct  AudioClips_t3516730637 
{
public:
	// UnityEngine.AudioClip GuitarNoteClips/AudioClips::clip
	AudioClip_t3714538611 * ___clip_0;

public:
	inline static int32_t get_offset_of_clip_0() { return static_cast<int32_t>(offsetof(AudioClips_t3516730637, ___clip_0)); }
	inline AudioClip_t3714538611 * get_clip_0() const { return ___clip_0; }
	inline AudioClip_t3714538611 ** get_address_of_clip_0() { return &___clip_0; }
	inline void set_clip_0(AudioClip_t3714538611 * value)
	{
		___clip_0 = value;
		Il2CppCodeGenWriteBarrier(&___clip_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
