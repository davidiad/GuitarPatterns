#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// System.Reflection.MonoProperty/Getter`2<System.Object,System.Object>
struct Getter_2_t539570894;
// System.Object
struct Il2CppObject;
// System.IAsyncResult
struct IAsyncResult_t537683269;
// System.AsyncCallback
struct AsyncCallback_t1363551830;
// System.Reflection.MonoProperty/StaticGetter`1<System.Object>
struct StaticGetter_1_t171826611;
// UnityEngine.Events.UnityEvent`1<System.Object>
struct UnityEvent_1_t4074528527;
// UnityEngine.Events.UnityEvent`2<System.Object,System.Object>
struct UnityEvent_2_t3775219180;
// UnityEngine.Events.UnityEvent`3<System.Object,System.Object,System.Object>
struct UnityEvent_3_t1749754057;
// UnityEngine.Events.UnityEvent`4<System.Object,System.Object,System.Object,System.Object>
struct UnityEvent_4_t1065917714;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array2840145358.h"
#include "mscorlib_System_Reflection_MonoProperty_Getter_2_ge539570894.h"
#include "mscorlib_System_Reflection_MonoProperty_Getter_2_ge539570894MethodDeclarations.h"
#include "mscorlib_System_Object837106420.h"
#include "mscorlib_System_IntPtr676692020.h"
#include "mscorlib_System_Void2779279689.h"
#include "mscorlib_System_AsyncCallback1363551830.h"
#include "mscorlib_System_Reflection_MonoProperty_StaticGette171826611.h"
#include "mscorlib_System_Reflection_MonoProperty_StaticGette171826611MethodDeclarations.h"
#include "UnityEngine_UnityEngine_CastHelper_1_gen4244616972.h"
#include "UnityEngine_UnityEngine_CastHelper_1_gen4244616972MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_1_gen4074528527.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_1_gen4074528527MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityEventBase2174897510MethodDeclarations.h"
#include "mscorlib_ArrayTypes.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_2_gen3775219180.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_2_gen3775219180MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_3_gen1749754057.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_3_gen1749754057MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_4_gen1065917714.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent_4_gen1065917714MethodDeclarations.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Reflection.MonoProperty/Getter`2<System.Object,System.Object>::.ctor(System.Object,System.IntPtr)
extern "C"  void Getter_2__ctor_m4236926794_gshared (Getter_2_t539570894 * __this, Il2CppObject * ___object, IntPtr_t ___method, const MethodInfo* method)
{
	__this->set_method_ptr_0((methodPointerType)((MethodInfo*)___method.get_m_value_0())->method);
	__this->set_method_3(___method);
	__this->set_m_target_2(___object);
}
// R System.Reflection.MonoProperty/Getter`2<System.Object,System.Object>::Invoke(T)
extern "C"  Il2CppObject * Getter_2_Invoke_m410564889_gshared (Getter_2_t539570894 * __this, Il2CppObject * ____this, const MethodInfo* method)
{
	if(__this->get_prev_9() != NULL)
	{
		Getter_2_Invoke_m410564889((Getter_2_t539570894 *)__this->get_prev_9(),____this, method);
	}
	il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found((MethodInfo*)(__this->get_method_3().get_m_value_0()));
	bool ___methodIsStatic = MethodIsStatic((MethodInfo*)(__this->get_method_3().get_m_value_0()));
	if (__this->get_m_target_2() != NULL && ___methodIsStatic)
	{
		typedef Il2CppObject * (*FunctionPointerType) (Il2CppObject *, void* __this, Il2CppObject * ____this, const MethodInfo* method);
		return ((FunctionPointerType)__this->get_method_ptr_0())(NULL,il2cpp_codegen_get_delegate_this(__this),____this,(MethodInfo*)(__this->get_method_3().get_m_value_0()));
	}
	else if (__this->get_m_target_2() != NULL || ___methodIsStatic)
	{
		typedef Il2CppObject * (*FunctionPointerType) (void* __this, Il2CppObject * ____this, const MethodInfo* method);
		return ((FunctionPointerType)__this->get_method_ptr_0())(il2cpp_codegen_get_delegate_this(__this),____this,(MethodInfo*)(__this->get_method_3().get_m_value_0()));
	}
	else
	{
		typedef Il2CppObject * (*FunctionPointerType) (void* __this, const MethodInfo* method);
		return ((FunctionPointerType)__this->get_method_ptr_0())(____this,(MethodInfo*)(__this->get_method_3().get_m_value_0()));
	}
}
// System.IAsyncResult System.Reflection.MonoProperty/Getter`2<System.Object,System.Object>::BeginInvoke(T,System.AsyncCallback,System.Object)
extern "C"  Il2CppObject * Getter_2_BeginInvoke_m3146221447_gshared (Getter_2_t539570894 * __this, Il2CppObject * ____this, AsyncCallback_t1363551830 * ___callback, Il2CppObject * ___object, const MethodInfo* method)
{
	void *__d_args[2] = {0};
	__d_args[0] = ____this;
	return (Il2CppObject *)il2cpp_delegate_begin_invoke((Il2CppDelegate*)__this, __d_args, (Il2CppDelegate*)___callback, (Il2CppObject*)___object);
}
// R System.Reflection.MonoProperty/Getter`2<System.Object,System.Object>::EndInvoke(System.IAsyncResult)
extern "C"  Il2CppObject * Getter_2_EndInvoke_m1749574747_gshared (Getter_2_t539570894 * __this, Il2CppObject * ___result, const MethodInfo* method)
{
	Il2CppObject *__result = il2cpp_delegate_end_invoke((Il2CppAsyncResult*) ___result, 0);
	return (Il2CppObject *)__result;
}
// System.Void System.Reflection.MonoProperty/StaticGetter`1<System.Object>::.ctor(System.Object,System.IntPtr)
extern "C"  void StaticGetter_1__ctor_m3357261135_gshared (StaticGetter_1_t171826611 * __this, Il2CppObject * ___object, IntPtr_t ___method, const MethodInfo* method)
{
	__this->set_method_ptr_0((methodPointerType)((MethodInfo*)___method.get_m_value_0())->method);
	__this->set_method_3(___method);
	__this->set_m_target_2(___object);
}
// R System.Reflection.MonoProperty/StaticGetter`1<System.Object>::Invoke()
extern "C"  Il2CppObject * StaticGetter_1_Invoke_m3410367530_gshared (StaticGetter_1_t171826611 * __this, const MethodInfo* method)
{
	if(__this->get_prev_9() != NULL)
	{
		StaticGetter_1_Invoke_m3410367530((StaticGetter_1_t171826611 *)__this->get_prev_9(), method);
	}
	il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found((MethodInfo*)(__this->get_method_3().get_m_value_0()));
	bool ___methodIsStatic = MethodIsStatic((MethodInfo*)(__this->get_method_3().get_m_value_0()));
	if ((__this->get_m_target_2() != NULL || MethodHasParameters((MethodInfo*)(__this->get_method_3().get_m_value_0()))) && ___methodIsStatic)
	{
		typedef Il2CppObject * (*FunctionPointerType) (Il2CppObject *, void* __this, const MethodInfo* method);
		return ((FunctionPointerType)__this->get_method_ptr_0())(NULL,il2cpp_codegen_get_delegate_this(__this),(MethodInfo*)(__this->get_method_3().get_m_value_0()));
	}
	else
	{
		typedef Il2CppObject * (*FunctionPointerType) (void* __this, const MethodInfo* method);
		return ((FunctionPointerType)__this->get_method_ptr_0())(il2cpp_codegen_get_delegate_this(__this),(MethodInfo*)(__this->get_method_3().get_m_value_0()));
	}
}
// System.IAsyncResult System.Reflection.MonoProperty/StaticGetter`1<System.Object>::BeginInvoke(System.AsyncCallback,System.Object)
extern "C"  Il2CppObject * StaticGetter_1_BeginInvoke_m3837643130_gshared (StaticGetter_1_t171826611 * __this, AsyncCallback_t1363551830 * ___callback, Il2CppObject * ___object, const MethodInfo* method)
{
	void *__d_args[1] = {0};
	return (Il2CppObject *)il2cpp_delegate_begin_invoke((Il2CppDelegate*)__this, __d_args, (Il2CppDelegate*)___callback, (Il2CppObject*)___object);
}
// R System.Reflection.MonoProperty/StaticGetter`1<System.Object>::EndInvoke(System.IAsyncResult)
extern "C"  Il2CppObject * StaticGetter_1_EndInvoke_m3212189152_gshared (StaticGetter_1_t171826611 * __this, Il2CppObject * ___result, const MethodInfo* method)
{
	Il2CppObject *__result = il2cpp_delegate_end_invoke((Il2CppAsyncResult*) ___result, 0);
	return (Il2CppObject *)__result;
}
// System.Void UnityEngine.Events.UnityEvent`1<System.Object>::.ctor()
extern TypeInfo* ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var;
extern const uint32_t UnityEvent_1__ctor_m4139691420_MetadataUsageId;
extern "C"  void UnityEvent_1__ctor_m4139691420_gshared (UnityEvent_1_t4074528527 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (UnityEvent_1__ctor_m4139691420_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		__this->set_m_InvokeArray_4(((ObjectU5BU5D_t11523773*)SZArrayNew(ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var, (uint32_t)1)));
		NullCheck((UnityEventBase_t2174897510 *)__this);
		UnityEventBase__ctor_m199506446((UnityEventBase_t2174897510 *)__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Events.UnityEvent`2<System.Object,System.Object>::.ctor()
extern TypeInfo* ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var;
extern const uint32_t UnityEvent_2__ctor_m1950601551_MetadataUsageId;
extern "C"  void UnityEvent_2__ctor_m1950601551_gshared (UnityEvent_2_t3775219180 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (UnityEvent_2__ctor_m1950601551_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		__this->set_m_InvokeArray_4(((ObjectU5BU5D_t11523773*)SZArrayNew(ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var, (uint32_t)2)));
		NullCheck((UnityEventBase_t2174897510 *)__this);
		UnityEventBase__ctor_m199506446((UnityEventBase_t2174897510 *)__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Events.UnityEvent`3<System.Object,System.Object,System.Object>::.ctor()
extern TypeInfo* ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var;
extern const uint32_t UnityEvent_3__ctor_m4248091138_MetadataUsageId;
extern "C"  void UnityEvent_3__ctor_m4248091138_gshared (UnityEvent_3_t1749754057 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (UnityEvent_3__ctor_m4248091138_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		__this->set_m_InvokeArray_4(((ObjectU5BU5D_t11523773*)SZArrayNew(ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var, (uint32_t)3)));
		NullCheck((UnityEventBase_t2174897510 *)__this);
		UnityEventBase__ctor_m199506446((UnityEventBase_t2174897510 *)__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Events.UnityEvent`4<System.Object,System.Object,System.Object,System.Object>::.ctor()
extern TypeInfo* ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var;
extern const uint32_t UnityEvent_4__ctor_m492943285_MetadataUsageId;
extern "C"  void UnityEvent_4__ctor_m492943285_gshared (UnityEvent_4_t1065917714 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (UnityEvent_4__ctor_m492943285_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		__this->set_m_InvokeArray_4(((ObjectU5BU5D_t11523773*)SZArrayNew(ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var, (uint32_t)4)));
		NullCheck((UnityEventBase_t2174897510 *)__this);
		UnityEventBase__ctor_m199506446((UnityEventBase_t2174897510 *)__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
