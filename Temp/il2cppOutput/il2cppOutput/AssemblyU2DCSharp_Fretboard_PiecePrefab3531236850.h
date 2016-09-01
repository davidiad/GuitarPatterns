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

#include "mscorlib_System_ValueType4014882752.h"
#include "AssemblyU2DCSharp_Fretboard_PieceType2117764904.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Fretboard/PiecePrefab
struct  PiecePrefab_t3531236850 
{
public:
	// Fretboard/PieceType Fretboard/PiecePrefab::type
	int32_t ___type_0;
	// UnityEngine.GameObject Fretboard/PiecePrefab::prefab
	GameObject_t4012695102 * ___prefab_1;

public:
	inline static int32_t get_offset_of_type_0() { return static_cast<int32_t>(offsetof(PiecePrefab_t3531236850, ___type_0)); }
	inline int32_t get_type_0() const { return ___type_0; }
	inline int32_t* get_address_of_type_0() { return &___type_0; }
	inline void set_type_0(int32_t value)
	{
		___type_0 = value;
	}

	inline static int32_t get_offset_of_prefab_1() { return static_cast<int32_t>(offsetof(PiecePrefab_t3531236850, ___prefab_1)); }
	inline GameObject_t4012695102 * get_prefab_1() const { return ___prefab_1; }
	inline GameObject_t4012695102 ** get_address_of_prefab_1() { return &___prefab_1; }
	inline void set_prefab_1(GameObject_t4012695102 * value)
	{
		___prefab_1 = value;
		Il2CppCodeGenWriteBarrier(&___prefab_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
