#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Fretboard/PiecePrefab[]
struct PiecePrefabU5BU5D_t2307676679;
// UnityEngine.GameObject
struct GameObject_t4012695102;
// System.Collections.Generic.Dictionary`2<Fretboard/PieceType,UnityEngine.GameObject>
struct Dictionary_2_t53793924;
// Note[,]
struct NoteU5BU2CU5D_t3526180712;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Fretboard
struct  Fretboard_t2002570539  : public MonoBehaviour_t3012272455
{
public:
	// System.Int32 Fretboard::xDim
	int32_t ___xDim_2;
	// System.Int32 Fretboard::yDim
	int32_t ___yDim_3;
	// Fretboard/PiecePrefab[] Fretboard::piecePrefabs
	PiecePrefabU5BU5D_t2307676679* ___piecePrefabs_4;
	// UnityEngine.GameObject Fretboard::backgroundPrefab
	GameObject_t4012695102 * ___backgroundPrefab_5;
	// System.Collections.Generic.Dictionary`2<Fretboard/PieceType,UnityEngine.GameObject> Fretboard::piecePrefabDict
	Dictionary_2_t53793924 * ___piecePrefabDict_6;
	// Note[,] Fretboard::notes
	NoteU5BU2CU5D_t3526180712* ___notes_7;

public:
	inline static int32_t get_offset_of_xDim_2() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___xDim_2)); }
	inline int32_t get_xDim_2() const { return ___xDim_2; }
	inline int32_t* get_address_of_xDim_2() { return &___xDim_2; }
	inline void set_xDim_2(int32_t value)
	{
		___xDim_2 = value;
	}

	inline static int32_t get_offset_of_yDim_3() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___yDim_3)); }
	inline int32_t get_yDim_3() const { return ___yDim_3; }
	inline int32_t* get_address_of_yDim_3() { return &___yDim_3; }
	inline void set_yDim_3(int32_t value)
	{
		___yDim_3 = value;
	}

	inline static int32_t get_offset_of_piecePrefabs_4() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___piecePrefabs_4)); }
	inline PiecePrefabU5BU5D_t2307676679* get_piecePrefabs_4() const { return ___piecePrefabs_4; }
	inline PiecePrefabU5BU5D_t2307676679** get_address_of_piecePrefabs_4() { return &___piecePrefabs_4; }
	inline void set_piecePrefabs_4(PiecePrefabU5BU5D_t2307676679* value)
	{
		___piecePrefabs_4 = value;
		Il2CppCodeGenWriteBarrier(&___piecePrefabs_4, value);
	}

	inline static int32_t get_offset_of_backgroundPrefab_5() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___backgroundPrefab_5)); }
	inline GameObject_t4012695102 * get_backgroundPrefab_5() const { return ___backgroundPrefab_5; }
	inline GameObject_t4012695102 ** get_address_of_backgroundPrefab_5() { return &___backgroundPrefab_5; }
	inline void set_backgroundPrefab_5(GameObject_t4012695102 * value)
	{
		___backgroundPrefab_5 = value;
		Il2CppCodeGenWriteBarrier(&___backgroundPrefab_5, value);
	}

	inline static int32_t get_offset_of_piecePrefabDict_6() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___piecePrefabDict_6)); }
	inline Dictionary_2_t53793924 * get_piecePrefabDict_6() const { return ___piecePrefabDict_6; }
	inline Dictionary_2_t53793924 ** get_address_of_piecePrefabDict_6() { return &___piecePrefabDict_6; }
	inline void set_piecePrefabDict_6(Dictionary_2_t53793924 * value)
	{
		___piecePrefabDict_6 = value;
		Il2CppCodeGenWriteBarrier(&___piecePrefabDict_6, value);
	}

	inline static int32_t get_offset_of_notes_7() { return static_cast<int32_t>(offsetof(Fretboard_t2002570539, ___notes_7)); }
	inline NoteU5BU2CU5D_t3526180712* get_notes_7() const { return ___notes_7; }
	inline NoteU5BU2CU5D_t3526180712** get_address_of_notes_7() { return &___notes_7; }
	inline void set_notes_7(NoteU5BU2CU5D_t3526180712* value)
	{
		___notes_7 = value;
		Il2CppCodeGenWriteBarrier(&___notes_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
