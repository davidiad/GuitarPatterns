#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// Note
struct Note_t2434066;
// Fretboard
struct Fretboard_t2002570539;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharp_Fretboard_PieceType2117764904.h"
#include "AssemblyU2DCSharp_Fretboard2002570539.h"

// System.Void Note::.ctor()
extern "C"  void Note__ctor_m3624721097 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// Fretboard Note::get_Fretboard()
extern "C"  Fretboard_t2002570539 * Note_get_Fretboard_m1883718529 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// Fretboard/PieceType Note::get_Type()
extern "C"  int32_t Note_get_Type_m4233391597 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 Note::get_NumPitches()
extern "C"  int32_t Note_get_NumPitches_m3531701818 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// Note Note::get_NoteComponent()
extern "C"  Note_t2434066 * Note_get_NoteComponent_m708380510 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Note::Awake()
extern "C"  void Note_Awake_m3862326316 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Note::Start()
extern "C"  void Note_Start_m2571858889 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Note::Init(Fretboard,Fretboard/PieceType,System.Int32,System.Int32)
extern "C"  void Note_Init_m213973156 (Note_t2434066 * __this, Fretboard_t2002570539 * ____fret, int32_t ____type, int32_t ___xValue, int32_t ____octave, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Note::OnMouseDown()
extern "C"  void Note_OnMouseDown_m2802671919 (Note_t2434066 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
