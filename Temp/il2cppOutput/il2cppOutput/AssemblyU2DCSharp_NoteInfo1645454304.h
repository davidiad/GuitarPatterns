#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// PitchName[]
struct PitchNameU5BU5D_t4256173738;
// System.Boolean[]
struct BooleanU5BU5D_t3804927312;
// System.Int32[]
struct Int32U5BU5D_t1809983122;
// System.String[]
struct StringU5BU5D_t2956870243;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// NoteInfo
struct  NoteInfo_t1645454304  : public MonoBehaviour_t3012272455
{
public:
	// PitchName[] NoteInfo::pitchNames
	PitchNameU5BU5D_t4256173738* ___pitchNames_2;
	// System.Boolean[] NoteInfo::sharps
	BooleanU5BU5D_t3804927312* ___sharps_3;
	// System.Int32[] NoteInfo::identifiers
	Int32U5BU5D_t1809983122* ___identifiers_4;
	// System.String[] NoteInfo::noteRichTexts
	StringU5BU5D_t2956870243* ___noteRichTexts_5;

public:
	inline static int32_t get_offset_of_pitchNames_2() { return static_cast<int32_t>(offsetof(NoteInfo_t1645454304, ___pitchNames_2)); }
	inline PitchNameU5BU5D_t4256173738* get_pitchNames_2() const { return ___pitchNames_2; }
	inline PitchNameU5BU5D_t4256173738** get_address_of_pitchNames_2() { return &___pitchNames_2; }
	inline void set_pitchNames_2(PitchNameU5BU5D_t4256173738* value)
	{
		___pitchNames_2 = value;
		Il2CppCodeGenWriteBarrier(&___pitchNames_2, value);
	}

	inline static int32_t get_offset_of_sharps_3() { return static_cast<int32_t>(offsetof(NoteInfo_t1645454304, ___sharps_3)); }
	inline BooleanU5BU5D_t3804927312* get_sharps_3() const { return ___sharps_3; }
	inline BooleanU5BU5D_t3804927312** get_address_of_sharps_3() { return &___sharps_3; }
	inline void set_sharps_3(BooleanU5BU5D_t3804927312* value)
	{
		___sharps_3 = value;
		Il2CppCodeGenWriteBarrier(&___sharps_3, value);
	}

	inline static int32_t get_offset_of_identifiers_4() { return static_cast<int32_t>(offsetof(NoteInfo_t1645454304, ___identifiers_4)); }
	inline Int32U5BU5D_t1809983122* get_identifiers_4() const { return ___identifiers_4; }
	inline Int32U5BU5D_t1809983122** get_address_of_identifiers_4() { return &___identifiers_4; }
	inline void set_identifiers_4(Int32U5BU5D_t1809983122* value)
	{
		___identifiers_4 = value;
		Il2CppCodeGenWriteBarrier(&___identifiers_4, value);
	}

	inline static int32_t get_offset_of_noteRichTexts_5() { return static_cast<int32_t>(offsetof(NoteInfo_t1645454304, ___noteRichTexts_5)); }
	inline StringU5BU5D_t2956870243* get_noteRichTexts_5() const { return ___noteRichTexts_5; }
	inline StringU5BU5D_t2956870243** get_address_of_noteRichTexts_5() { return &___noteRichTexts_5; }
	inline void set_noteRichTexts_5(StringU5BU5D_t2956870243* value)
	{
		___noteRichTexts_5 = value;
		Il2CppCodeGenWriteBarrier(&___noteRichTexts_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
