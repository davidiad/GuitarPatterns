#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String
struct String_t;
// NoteInfo
struct NoteInfo_t1645454304;
// UnityEngine.AudioClip
struct AudioClip_t3714538611;
// GuitarNoteClips
struct GuitarNoteClips_t2312880327;
// UnityEngine.AudioSource
struct AudioSource_t3628549054;
// PitchName[]
struct PitchNameU5BU5D_t4256173738;
// System.Int32[]
struct Int32U5BU5D_t1809983122;
// System.Boolean[]
struct BooleanU5BU5D_t3804927312;
// Fretboard
struct Fretboard_t2002570539;
// Note/NoteMeshObject[]
struct NoteMeshObjectU5BU5D_t3956456459;
// UnityEngine.TextMesh
struct TextMesh_t583678247;
// Note
struct Note_t2434066;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "AssemblyU2DCSharp_PitchName2547986891.h"
#include "AssemblyU2DCSharp_Fretboard_PieceType2117764904.h"
#include "AssemblyU2DCSharp_Note_PitchType2548188794.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Note
struct  Note_t2434066  : public MonoBehaviour_t3012272455
{
public:
	// PitchName Note::notePitch
	int32_t ___notePitch_2;
	// System.Boolean Note::sharp
	bool ___sharp_3;
	// System.Int32 Note::noteIdentifer
	int32_t ___noteIdentifer_4;
	// System.String Note::noteRichText
	String_t* ___noteRichText_5;
	// System.Single Note::pitchAdjust
	float ___pitchAdjust_6;
	// NoteInfo Note::noteInfo
	NoteInfo_t1645454304 * ___noteInfo_7;
	// UnityEngine.AudioClip Note::clip
	AudioClip_t3714538611 * ___clip_8;
	// GuitarNoteClips Note::clips
	GuitarNoteClips_t2312880327 * ___clips_9;
	// UnityEngine.AudioSource Note::noteSource
	AudioSource_t3628549054 * ___noteSource_10;
	// System.Int32 Note::octave
	int32_t ___octave_11;
	// PitchName[] Note::pitchNames
	PitchNameU5BU5D_t4256173738* ___pitchNames_12;
	// System.Int32[] Note::identifiers
	Int32U5BU5D_t1809983122* ___identifiers_13;
	// System.Boolean[] Note::gmajor
	BooleanU5BU5D_t3804927312* ___gmajor_14;
	// System.Int32 Note::notemeshText
	int32_t ___notemeshText_15;
	// Fretboard Note::fretboard
	Fretboard_t2002570539 * ___fretboard_16;
	// Fretboard/PieceType Note::type
	int32_t ___type_17;
	// Note/NoteMeshObject[] Note::noteMeshObjects
	NoteMeshObjectU5BU5D_t3956456459* ___noteMeshObjects_18;
	// Note/PitchType Note::pitch
	int32_t ___pitch_19;
	// UnityEngine.TextMesh Note::noteText
	TextMesh_t583678247 * ___noteText_20;
	// Note Note::noteComponent
	Note_t2434066 * ___noteComponent_21;

public:
	inline static int32_t get_offset_of_notePitch_2() { return static_cast<int32_t>(offsetof(Note_t2434066, ___notePitch_2)); }
	inline int32_t get_notePitch_2() const { return ___notePitch_2; }
	inline int32_t* get_address_of_notePitch_2() { return &___notePitch_2; }
	inline void set_notePitch_2(int32_t value)
	{
		___notePitch_2 = value;
	}

	inline static int32_t get_offset_of_sharp_3() { return static_cast<int32_t>(offsetof(Note_t2434066, ___sharp_3)); }
	inline bool get_sharp_3() const { return ___sharp_3; }
	inline bool* get_address_of_sharp_3() { return &___sharp_3; }
	inline void set_sharp_3(bool value)
	{
		___sharp_3 = value;
	}

	inline static int32_t get_offset_of_noteIdentifer_4() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteIdentifer_4)); }
	inline int32_t get_noteIdentifer_4() const { return ___noteIdentifer_4; }
	inline int32_t* get_address_of_noteIdentifer_4() { return &___noteIdentifer_4; }
	inline void set_noteIdentifer_4(int32_t value)
	{
		___noteIdentifer_4 = value;
	}

	inline static int32_t get_offset_of_noteRichText_5() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteRichText_5)); }
	inline String_t* get_noteRichText_5() const { return ___noteRichText_5; }
	inline String_t** get_address_of_noteRichText_5() { return &___noteRichText_5; }
	inline void set_noteRichText_5(String_t* value)
	{
		___noteRichText_5 = value;
		Il2CppCodeGenWriteBarrier(&___noteRichText_5, value);
	}

	inline static int32_t get_offset_of_pitchAdjust_6() { return static_cast<int32_t>(offsetof(Note_t2434066, ___pitchAdjust_6)); }
	inline float get_pitchAdjust_6() const { return ___pitchAdjust_6; }
	inline float* get_address_of_pitchAdjust_6() { return &___pitchAdjust_6; }
	inline void set_pitchAdjust_6(float value)
	{
		___pitchAdjust_6 = value;
	}

	inline static int32_t get_offset_of_noteInfo_7() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteInfo_7)); }
	inline NoteInfo_t1645454304 * get_noteInfo_7() const { return ___noteInfo_7; }
	inline NoteInfo_t1645454304 ** get_address_of_noteInfo_7() { return &___noteInfo_7; }
	inline void set_noteInfo_7(NoteInfo_t1645454304 * value)
	{
		___noteInfo_7 = value;
		Il2CppCodeGenWriteBarrier(&___noteInfo_7, value);
	}

	inline static int32_t get_offset_of_clip_8() { return static_cast<int32_t>(offsetof(Note_t2434066, ___clip_8)); }
	inline AudioClip_t3714538611 * get_clip_8() const { return ___clip_8; }
	inline AudioClip_t3714538611 ** get_address_of_clip_8() { return &___clip_8; }
	inline void set_clip_8(AudioClip_t3714538611 * value)
	{
		___clip_8 = value;
		Il2CppCodeGenWriteBarrier(&___clip_8, value);
	}

	inline static int32_t get_offset_of_clips_9() { return static_cast<int32_t>(offsetof(Note_t2434066, ___clips_9)); }
	inline GuitarNoteClips_t2312880327 * get_clips_9() const { return ___clips_9; }
	inline GuitarNoteClips_t2312880327 ** get_address_of_clips_9() { return &___clips_9; }
	inline void set_clips_9(GuitarNoteClips_t2312880327 * value)
	{
		___clips_9 = value;
		Il2CppCodeGenWriteBarrier(&___clips_9, value);
	}

	inline static int32_t get_offset_of_noteSource_10() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteSource_10)); }
	inline AudioSource_t3628549054 * get_noteSource_10() const { return ___noteSource_10; }
	inline AudioSource_t3628549054 ** get_address_of_noteSource_10() { return &___noteSource_10; }
	inline void set_noteSource_10(AudioSource_t3628549054 * value)
	{
		___noteSource_10 = value;
		Il2CppCodeGenWriteBarrier(&___noteSource_10, value);
	}

	inline static int32_t get_offset_of_octave_11() { return static_cast<int32_t>(offsetof(Note_t2434066, ___octave_11)); }
	inline int32_t get_octave_11() const { return ___octave_11; }
	inline int32_t* get_address_of_octave_11() { return &___octave_11; }
	inline void set_octave_11(int32_t value)
	{
		___octave_11 = value;
	}

	inline static int32_t get_offset_of_pitchNames_12() { return static_cast<int32_t>(offsetof(Note_t2434066, ___pitchNames_12)); }
	inline PitchNameU5BU5D_t4256173738* get_pitchNames_12() const { return ___pitchNames_12; }
	inline PitchNameU5BU5D_t4256173738** get_address_of_pitchNames_12() { return &___pitchNames_12; }
	inline void set_pitchNames_12(PitchNameU5BU5D_t4256173738* value)
	{
		___pitchNames_12 = value;
		Il2CppCodeGenWriteBarrier(&___pitchNames_12, value);
	}

	inline static int32_t get_offset_of_identifiers_13() { return static_cast<int32_t>(offsetof(Note_t2434066, ___identifiers_13)); }
	inline Int32U5BU5D_t1809983122* get_identifiers_13() const { return ___identifiers_13; }
	inline Int32U5BU5D_t1809983122** get_address_of_identifiers_13() { return &___identifiers_13; }
	inline void set_identifiers_13(Int32U5BU5D_t1809983122* value)
	{
		___identifiers_13 = value;
		Il2CppCodeGenWriteBarrier(&___identifiers_13, value);
	}

	inline static int32_t get_offset_of_gmajor_14() { return static_cast<int32_t>(offsetof(Note_t2434066, ___gmajor_14)); }
	inline BooleanU5BU5D_t3804927312* get_gmajor_14() const { return ___gmajor_14; }
	inline BooleanU5BU5D_t3804927312** get_address_of_gmajor_14() { return &___gmajor_14; }
	inline void set_gmajor_14(BooleanU5BU5D_t3804927312* value)
	{
		___gmajor_14 = value;
		Il2CppCodeGenWriteBarrier(&___gmajor_14, value);
	}

	inline static int32_t get_offset_of_notemeshText_15() { return static_cast<int32_t>(offsetof(Note_t2434066, ___notemeshText_15)); }
	inline int32_t get_notemeshText_15() const { return ___notemeshText_15; }
	inline int32_t* get_address_of_notemeshText_15() { return &___notemeshText_15; }
	inline void set_notemeshText_15(int32_t value)
	{
		___notemeshText_15 = value;
	}

	inline static int32_t get_offset_of_fretboard_16() { return static_cast<int32_t>(offsetof(Note_t2434066, ___fretboard_16)); }
	inline Fretboard_t2002570539 * get_fretboard_16() const { return ___fretboard_16; }
	inline Fretboard_t2002570539 ** get_address_of_fretboard_16() { return &___fretboard_16; }
	inline void set_fretboard_16(Fretboard_t2002570539 * value)
	{
		___fretboard_16 = value;
		Il2CppCodeGenWriteBarrier(&___fretboard_16, value);
	}

	inline static int32_t get_offset_of_type_17() { return static_cast<int32_t>(offsetof(Note_t2434066, ___type_17)); }
	inline int32_t get_type_17() const { return ___type_17; }
	inline int32_t* get_address_of_type_17() { return &___type_17; }
	inline void set_type_17(int32_t value)
	{
		___type_17 = value;
	}

	inline static int32_t get_offset_of_noteMeshObjects_18() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteMeshObjects_18)); }
	inline NoteMeshObjectU5BU5D_t3956456459* get_noteMeshObjects_18() const { return ___noteMeshObjects_18; }
	inline NoteMeshObjectU5BU5D_t3956456459** get_address_of_noteMeshObjects_18() { return &___noteMeshObjects_18; }
	inline void set_noteMeshObjects_18(NoteMeshObjectU5BU5D_t3956456459* value)
	{
		___noteMeshObjects_18 = value;
		Il2CppCodeGenWriteBarrier(&___noteMeshObjects_18, value);
	}

	inline static int32_t get_offset_of_pitch_19() { return static_cast<int32_t>(offsetof(Note_t2434066, ___pitch_19)); }
	inline int32_t get_pitch_19() const { return ___pitch_19; }
	inline int32_t* get_address_of_pitch_19() { return &___pitch_19; }
	inline void set_pitch_19(int32_t value)
	{
		___pitch_19 = value;
	}

	inline static int32_t get_offset_of_noteText_20() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteText_20)); }
	inline TextMesh_t583678247 * get_noteText_20() const { return ___noteText_20; }
	inline TextMesh_t583678247 ** get_address_of_noteText_20() { return &___noteText_20; }
	inline void set_noteText_20(TextMesh_t583678247 * value)
	{
		___noteText_20 = value;
		Il2CppCodeGenWriteBarrier(&___noteText_20, value);
	}

	inline static int32_t get_offset_of_noteComponent_21() { return static_cast<int32_t>(offsetof(Note_t2434066, ___noteComponent_21)); }
	inline Note_t2434066 * get_noteComponent_21() const { return ___noteComponent_21; }
	inline Note_t2434066 ** get_address_of_noteComponent_21() { return &___noteComponent_21; }
	inline void set_noteComponent_21(Note_t2434066 * value)
	{
		___noteComponent_21 = value;
		Il2CppCodeGenWriteBarrier(&___noteComponent_21, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
