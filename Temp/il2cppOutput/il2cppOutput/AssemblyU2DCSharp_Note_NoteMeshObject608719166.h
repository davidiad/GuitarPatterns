#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;
// System.String
struct String_t;

#include "mscorlib_System_ValueType4014882752.h"
#include "AssemblyU2DCSharp_Note_PitchType2548188794.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Note/NoteMeshObject
struct  NoteMeshObject_t608719166 
{
public:
	// Note/PitchType Note/NoteMeshObject::pitch
	int32_t ___pitch_0;
	// UnityEngine.GameObject Note/NoteMeshObject::noteObject
	GameObject_t4012695102 * ___noteObject_1;
	// System.String Note/NoteMeshObject::pitchText
	String_t* ___pitchText_2;

public:
	inline static int32_t get_offset_of_pitch_0() { return static_cast<int32_t>(offsetof(NoteMeshObject_t608719166, ___pitch_0)); }
	inline int32_t get_pitch_0() const { return ___pitch_0; }
	inline int32_t* get_address_of_pitch_0() { return &___pitch_0; }
	inline void set_pitch_0(int32_t value)
	{
		___pitch_0 = value;
	}

	inline static int32_t get_offset_of_noteObject_1() { return static_cast<int32_t>(offsetof(NoteMeshObject_t608719166, ___noteObject_1)); }
	inline GameObject_t4012695102 * get_noteObject_1() const { return ___noteObject_1; }
	inline GameObject_t4012695102 ** get_address_of_noteObject_1() { return &___noteObject_1; }
	inline void set_noteObject_1(GameObject_t4012695102 * value)
	{
		___noteObject_1 = value;
		Il2CppCodeGenWriteBarrier(&___noteObject_1, value);
	}

	inline static int32_t get_offset_of_pitchText_2() { return static_cast<int32_t>(offsetof(NoteMeshObject_t608719166, ___pitchText_2)); }
	inline String_t* get_pitchText_2() const { return ___pitchText_2; }
	inline String_t** get_address_of_pitchText_2() { return &___pitchText_2; }
	inline void set_pitchText_2(String_t* value)
	{
		___pitchText_2 = value;
		Il2CppCodeGenWriteBarrier(&___pitchText_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
