#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioClip[]
struct AudioClipU5BU5D_t2889538658;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GuitarNoteClips
struct  GuitarNoteClips_t2312880327  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.AudioClip[] GuitarNoteClips::audioClips
	AudioClipU5BU5D_t2889538658* ___audioClips_2;

public:
	inline static int32_t get_offset_of_audioClips_2() { return static_cast<int32_t>(offsetof(GuitarNoteClips_t2312880327, ___audioClips_2)); }
	inline AudioClipU5BU5D_t2889538658* get_audioClips_2() const { return ___audioClips_2; }
	inline AudioClipU5BU5D_t2889538658** get_address_of_audioClips_2() { return &___audioClips_2; }
	inline void set_audioClips_2(AudioClipU5BU5D_t2889538658* value)
	{
		___audioClips_2 = value;
		Il2CppCodeGenWriteBarrier(&___audioClips_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
