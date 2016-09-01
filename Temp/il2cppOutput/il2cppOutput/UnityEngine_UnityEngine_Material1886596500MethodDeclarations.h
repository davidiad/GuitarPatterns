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

// UnityEngine.Material
struct Material_t1886596500;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String968488902.h"
#include "UnityEngine_UnityEngine_Color1588175760.h"
#include "UnityEngine_UnityEngine_Material1886596500.h"

// System.Void UnityEngine.Material::SetColor(System.String,UnityEngine.Color)
extern "C"  void Material_SetColor_m1918430019 (Material_t1886596500 * __this, String_t* ___propertyName, Color_t1588175760  ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::SetColor(System.Int32,UnityEngine.Color)
extern "C"  void Material_SetColor_m54957808 (Material_t1886596500 * __this, int32_t ___nameID, Color_t1588175760  ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Material::INTERNAL_CALL_SetColor(UnityEngine.Material,System.Int32,UnityEngine.Color&)
extern "C"  void Material_INTERNAL_CALL_SetColor_m3209011477 (Il2CppObject * __this /* static, unused */, Material_t1886596500 * ___self, int32_t ___nameID, Color_t1588175760 * ___color, const MethodInfo* method) IL2CPP_METHOD_ATTR;
