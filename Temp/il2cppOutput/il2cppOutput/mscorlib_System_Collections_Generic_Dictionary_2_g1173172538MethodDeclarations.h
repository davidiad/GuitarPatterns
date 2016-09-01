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

// System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>
struct Dictionary_2_t1173172538;
// System.Collections.Generic.IEqualityComparer`1<Fretboard/PieceType>
struct IEqualityComparer_1_t147064259;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t2995724695;
// System.Object
struct Il2CppObject;
// System.Collections.Generic.KeyValuePair`2<Fretboard/PieceType,System.Object>[]
struct KeyValuePair_2U5BU5D_t4283548021;
// System.Array
struct Il2CppArray;
// System.Collections.IEnumerator
struct IEnumerator_t287207039;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Fretboard/PieceType,System.Object>>
struct IEnumerator_1_t2144810284;
// System.Collections.IDictionaryEnumerator
struct IDictionaryEnumerator_t1541724277;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Runtime_Serialization_Serializatio2995724695.h"
#include "mscorlib_System_Runtime_Serialization_StreamingCont986364934.h"
#include "mscorlib_System_Object837106420.h"
#include "mscorlib_System_Collections_Generic_KeyValuePair_2_661703836.h"
#include "mscorlib_System_Array2840145358.h"
#include "AssemblyU2DCSharp_Fretboard_PieceType2117764904.h"
#include "mscorlib_System_Collections_Generic_Dictionary_2_En940200479.h"
#include "mscorlib_System_Collections_DictionaryEntry130027246.h"

// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::.ctor()
extern "C"  void Dictionary_2__ctor_m315673637_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2__ctor_m315673637(__this, method) ((  void (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2__ctor_m315673637_gshared)(__this, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<TKey>)
extern "C"  void Dictionary_2__ctor_m1324452380_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject* ___comparer, const MethodInfo* method);
#define Dictionary_2__ctor_m1324452380(__this, ___comparer, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppObject*, const MethodInfo*))Dictionary_2__ctor_m1324452380_gshared)(__this, ___comparer, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::.ctor(System.Int32)
extern "C"  void Dictionary_2__ctor_m1400664566_gshared (Dictionary_2_t1173172538 * __this, int32_t ___capacity, const MethodInfo* method);
#define Dictionary_2__ctor_m1400664566(__this, ___capacity, method) ((  void (*) (Dictionary_2_t1173172538 *, int32_t, const MethodInfo*))Dictionary_2__ctor_m1400664566_gshared)(__this, ___capacity, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
extern "C"  void Dictionary_2__ctor_m3763530726_gshared (Dictionary_2_t1173172538 * __this, SerializationInfo_t2995724695 * ___info, StreamingContext_t986364934  ___context, const MethodInfo* method);
#define Dictionary_2__ctor_m3763530726(__this, ___info, ___context, method) ((  void (*) (Dictionary_2_t1173172538 *, SerializationInfo_t2995724695 *, StreamingContext_t986364934 , const MethodInfo*))Dictionary_2__ctor_m3763530726_gshared)(__this, ___info, ___context, method)
// System.Object System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.get_Item(System.Object)
extern "C"  Il2CppObject * Dictionary_2_System_Collections_IDictionary_get_Item_m1864269827_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_get_Item_m1864269827(__this, ___key, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_get_Item_m1864269827_gshared)(__this, ___key, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.set_Item(System.Object,System.Object)
extern "C"  void Dictionary_2_System_Collections_IDictionary_set_Item_m1039707944_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_set_Item_m1039707944(__this, ___key, ___value, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppObject *, Il2CppObject *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_set_Item_m1039707944_gshared)(__this, ___key, ___value, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.Add(System.Object,System.Object)
extern "C"  void Dictionary_2_System_Collections_IDictionary_Add_m2199303721_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_Add_m2199303721(__this, ___key, ___value, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppObject *, Il2CppObject *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_Add_m2199303721_gshared)(__this, ___key, ___value, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.Contains(System.Object)
extern "C"  bool Dictionary_2_System_Collections_IDictionary_Contains_m1775896365_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_Contains_m1775896365(__this, ___key, method) ((  bool (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_Contains_m1775896365_gshared)(__this, ___key, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.Remove(System.Object)
extern "C"  void Dictionary_2_System_Collections_IDictionary_Remove_m3791550822_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_Remove_m3791550822(__this, ___key, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_Remove_m3791550822_gshared)(__this, ___key, method)
// System.Object System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.ICollection.get_SyncRoot()
extern "C"  Il2CppObject * Dictionary_2_System_Collections_ICollection_get_SyncRoot_m1520724019_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_System_Collections_ICollection_get_SyncRoot_m1520724019(__this, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_System_Collections_ICollection_get_SyncRoot_m1520724019_gshared)(__this, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly()
extern "C"  bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_get_IsReadOnly_m2772091083_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_get_IsReadOnly_m2772091083(__this, method) ((  bool (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_get_IsReadOnly_m2772091083_gshared)(__this, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
extern "C"  void Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Add_m1345960700_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2_t661703836  ___keyValuePair, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Add_m1345960700(__this, ___keyValuePair, method) ((  void (*) (Dictionary_2_t1173172538 *, KeyValuePair_2_t661703836 , const MethodInfo*))Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Add_m1345960700_gshared)(__this, ___keyValuePair, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
extern "C"  bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Contains_m577953606_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2_t661703836  ___keyValuePair, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Contains_m577953606(__this, ___keyValuePair, method) ((  bool (*) (Dictionary_2_t1173172538 *, KeyValuePair_2_t661703836 , const MethodInfo*))Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Contains_m577953606_gshared)(__this, ___keyValuePair, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair`2<TKey,TValue>[],System.Int32)
extern "C"  void Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_CopyTo_m534012896_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2U5BU5D_t4283548021* ___array, int32_t ___index, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_CopyTo_m534012896(__this, ___array, ___index, method) ((  void (*) (Dictionary_2_t1173172538 *, KeyValuePair_2U5BU5D_t4283548021*, int32_t, const MethodInfo*))Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_CopyTo_m534012896_gshared)(__this, ___array, ___index, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
extern "C"  bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Remove_m1637621739_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2_t661703836  ___keyValuePair, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Remove_m1637621739(__this, ___keyValuePair, method) ((  bool (*) (Dictionary_2_t1173172538 *, KeyValuePair_2_t661703836 , const MethodInfo*))Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Remove_m1637621739_gshared)(__this, ___keyValuePair, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.ICollection.CopyTo(System.Array,System.Int32)
extern "C"  void Dictionary_2_System_Collections_ICollection_CopyTo_m254683327_gshared (Dictionary_2_t1173172538 * __this, Il2CppArray * ___array, int32_t ___index, const MethodInfo* method);
#define Dictionary_2_System_Collections_ICollection_CopyTo_m254683327(__this, ___array, ___index, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppArray *, int32_t, const MethodInfo*))Dictionary_2_System_Collections_ICollection_CopyTo_m254683327_gshared)(__this, ___array, ___index, method)
// System.Collections.IEnumerator System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IEnumerable.GetEnumerator()
extern "C"  Il2CppObject * Dictionary_2_System_Collections_IEnumerable_GetEnumerator_m3866120186_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_System_Collections_IEnumerable_GetEnumerator_m3866120186(__this, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_System_Collections_IEnumerable_GetEnumerator_m3866120186_gshared)(__this, method)
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<TKey,TValue>> System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
extern "C"  Il2CppObject* Dictionary_2_System_Collections_Generic_IEnumerableU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_GetEnumerator_m31027511_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_System_Collections_Generic_IEnumerableU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_GetEnumerator_m31027511(__this, method) ((  Il2CppObject* (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_System_Collections_Generic_IEnumerableU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_GetEnumerator_m31027511_gshared)(__this, method)
// System.Collections.IDictionaryEnumerator System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::System.Collections.IDictionary.GetEnumerator()
extern "C"  Il2CppObject * Dictionary_2_System_Collections_IDictionary_GetEnumerator_m3582587922_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_System_Collections_IDictionary_GetEnumerator_m3582587922(__this, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_System_Collections_IDictionary_GetEnumerator_m3582587922_gshared)(__this, method)
// System.Int32 System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::get_Count()
extern "C"  int32_t Dictionary_2_get_Count_m2431671821_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_get_Count_m2431671821(__this, method) ((  int32_t (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_get_Count_m2431671821_gshared)(__this, method)
// TValue System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::get_Item(TKey)
extern "C"  Il2CppObject * Dictionary_2_get_Item_m2176104894_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, const MethodInfo* method);
#define Dictionary_2_get_Item_m2176104894(__this, ___key, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, int32_t, const MethodInfo*))Dictionary_2_get_Item_m2176104894_gshared)(__this, ___key, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::set_Item(TKey,TValue)
extern "C"  void Dictionary_2_set_Item_m2619759909_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_set_Item_m2619759909(__this, ___key, ___value, method) ((  void (*) (Dictionary_2_t1173172538 *, int32_t, Il2CppObject *, const MethodInfo*))Dictionary_2_set_Item_m2619759909_gshared)(__this, ___key, ___value, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::Init(System.Int32,System.Collections.Generic.IEqualityComparer`1<TKey>)
extern "C"  void Dictionary_2_Init_m3344038813_gshared (Dictionary_2_t1173172538 * __this, int32_t ___capacity, Il2CppObject* ___hcp, const MethodInfo* method);
#define Dictionary_2_Init_m3344038813(__this, ___capacity, ___hcp, method) ((  void (*) (Dictionary_2_t1173172538 *, int32_t, Il2CppObject*, const MethodInfo*))Dictionary_2_Init_m3344038813_gshared)(__this, ___capacity, ___hcp, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::InitArrays(System.Int32)
extern "C"  void Dictionary_2_InitArrays_m384859578_gshared (Dictionary_2_t1173172538 * __this, int32_t ___size, const MethodInfo* method);
#define Dictionary_2_InitArrays_m384859578(__this, ___size, method) ((  void (*) (Dictionary_2_t1173172538 *, int32_t, const MethodInfo*))Dictionary_2_InitArrays_m384859578_gshared)(__this, ___size, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::CopyToCheck(System.Array,System.Int32)
extern "C"  void Dictionary_2_CopyToCheck_m1790954550_gshared (Dictionary_2_t1173172538 * __this, Il2CppArray * ___array, int32_t ___index, const MethodInfo* method);
#define Dictionary_2_CopyToCheck_m1790954550(__this, ___array, ___index, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppArray *, int32_t, const MethodInfo*))Dictionary_2_CopyToCheck_m1790954550_gshared)(__this, ___array, ___index, method)
// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::make_pair(TKey,TValue)
extern "C"  KeyValuePair_2_t661703836  Dictionary_2_make_pair_m1312432770_gshared (Il2CppObject * __this /* static, unused */, int32_t ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_make_pair_m1312432770(__this /* static, unused */, ___key, ___value, method) ((  KeyValuePair_2_t661703836  (*) (Il2CppObject * /* static, unused */, int32_t, Il2CppObject *, const MethodInfo*))Dictionary_2_make_pair_m1312432770_gshared)(__this /* static, unused */, ___key, ___value, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::CopyTo(System.Collections.Generic.KeyValuePair`2<TKey,TValue>[],System.Int32)
extern "C"  void Dictionary_2_CopyTo_m1115510489_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2U5BU5D_t4283548021* ___array, int32_t ___index, const MethodInfo* method);
#define Dictionary_2_CopyTo_m1115510489(__this, ___array, ___index, method) ((  void (*) (Dictionary_2_t1173172538 *, KeyValuePair_2U5BU5D_t4283548021*, int32_t, const MethodInfo*))Dictionary_2_CopyTo_m1115510489_gshared)(__this, ___array, ___index, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::Resize()
extern "C"  void Dictionary_2_Resize_m1253744819_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_Resize_m1253744819(__this, method) ((  void (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_Resize_m1253744819_gshared)(__this, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::Add(TKey,TValue)
extern "C"  void Dictionary_2_Add_m1475953200_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_Add_m1475953200(__this, ___key, ___value, method) ((  void (*) (Dictionary_2_t1173172538 *, int32_t, Il2CppObject *, const MethodInfo*))Dictionary_2_Add_m1475953200_gshared)(__this, ___key, ___value, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::Clear()
extern "C"  void Dictionary_2_Clear_m2016774224_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_Clear_m2016774224(__this, method) ((  void (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_Clear_m2016774224_gshared)(__this, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::ContainsKey(TKey)
extern "C"  bool Dictionary_2_ContainsKey_m3188593334_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, const MethodInfo* method);
#define Dictionary_2_ContainsKey_m3188593334(__this, ___key, method) ((  bool (*) (Dictionary_2_t1173172538 *, int32_t, const MethodInfo*))Dictionary_2_ContainsKey_m3188593334_gshared)(__this, ___key, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
extern "C"  void Dictionary_2_GetObjectData_m4126469443_gshared (Dictionary_2_t1173172538 * __this, SerializationInfo_t2995724695 * ___info, StreamingContext_t986364934  ___context, const MethodInfo* method);
#define Dictionary_2_GetObjectData_m4126469443(__this, ___info, ___context, method) ((  void (*) (Dictionary_2_t1173172538 *, SerializationInfo_t2995724695 *, StreamingContext_t986364934 , const MethodInfo*))Dictionary_2_GetObjectData_m4126469443_gshared)(__this, ___info, ___context, method)
// System.Void System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::OnDeserialization(System.Object)
extern "C"  void Dictionary_2_OnDeserialization_m3319372033_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___sender, const MethodInfo* method);
#define Dictionary_2_OnDeserialization_m3319372033(__this, ___sender, method) ((  void (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_OnDeserialization_m3319372033_gshared)(__this, ___sender, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::Remove(TKey)
extern "C"  bool Dictionary_2_Remove_m997379194_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, const MethodInfo* method);
#define Dictionary_2_Remove_m997379194(__this, ___key, method) ((  bool (*) (Dictionary_2_t1173172538 *, int32_t, const MethodInfo*))Dictionary_2_Remove_m997379194_gshared)(__this, ___key, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::TryGetValue(TKey,TValue&)
extern "C"  bool Dictionary_2_TryGetValue_m403657999_gshared (Dictionary_2_t1173172538 * __this, int32_t ___key, Il2CppObject ** ___value, const MethodInfo* method);
#define Dictionary_2_TryGetValue_m403657999(__this, ___key, ___value, method) ((  bool (*) (Dictionary_2_t1173172538 *, int32_t, Il2CppObject **, const MethodInfo*))Dictionary_2_TryGetValue_m403657999_gshared)(__this, ___key, ___value, method)
// TKey System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::ToTKey(System.Object)
extern "C"  int32_t Dictionary_2_ToTKey_m3977553807_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___key, const MethodInfo* method);
#define Dictionary_2_ToTKey_m3977553807(__this, ___key, method) ((  int32_t (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_ToTKey_m3977553807_gshared)(__this, ___key, method)
// TValue System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::ToTValue(System.Object)
extern "C"  Il2CppObject * Dictionary_2_ToTValue_m1028340111_gshared (Dictionary_2_t1173172538 * __this, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_ToTValue_m1028340111(__this, ___value, method) ((  Il2CppObject * (*) (Dictionary_2_t1173172538 *, Il2CppObject *, const MethodInfo*))Dictionary_2_ToTValue_m1028340111_gshared)(__this, ___value, method)
// System.Boolean System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::ContainsKeyValuePair(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
extern "C"  bool Dictionary_2_ContainsKeyValuePair_m2389912157_gshared (Dictionary_2_t1173172538 * __this, KeyValuePair_2_t661703836  ___pair, const MethodInfo* method);
#define Dictionary_2_ContainsKeyValuePair_m2389912157(__this, ___pair, method) ((  bool (*) (Dictionary_2_t1173172538 *, KeyValuePair_2_t661703836 , const MethodInfo*))Dictionary_2_ContainsKeyValuePair_m2389912157_gshared)(__this, ___pair, method)
// System.Collections.Generic.Dictionary`2/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::GetEnumerator()
extern "C"  Enumerator_t940200479  Dictionary_2_GetEnumerator_m3279526250_gshared (Dictionary_2_t1173172538 * __this, const MethodInfo* method);
#define Dictionary_2_GetEnumerator_m3279526250(__this, method) ((  Enumerator_t940200479  (*) (Dictionary_2_t1173172538 *, const MethodInfo*))Dictionary_2_GetEnumerator_m3279526250_gshared)(__this, method)
// System.Collections.DictionaryEntry System.Collections.Generic.Dictionary`2<Fretboard/PieceType,System.Object>::<CopyTo>m__0(TKey,TValue)
extern "C"  DictionaryEntry_t130027246  Dictionary_2_U3CCopyToU3Em__0_m3547759673_gshared (Il2CppObject * __this /* static, unused */, int32_t ___key, Il2CppObject * ___value, const MethodInfo* method);
#define Dictionary_2_U3CCopyToU3Em__0_m3547759673(__this /* static, unused */, ___key, ___value, method) ((  DictionaryEntry_t130027246  (*) (Il2CppObject * /* static, unused */, int32_t, Il2CppObject *, const MethodInfo*))Dictionary_2_U3CCopyToU3Em__0_m3547759673_gshared)(__this /* static, unused */, ___key, ___value, method)
