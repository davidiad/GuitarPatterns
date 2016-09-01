#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


// Note
struct Note_t2434066;

#include "mscorlib_System_Array2840145358.h"
#include "AssemblyU2DCSharp_Fretboard_PiecePrefab3531236850.h"
#include "AssemblyU2DCSharp_Fretboard_PieceType2117764904.h"
#include "AssemblyU2DCSharp_Note2434066.h"
#include "AssemblyU2DCSharp_Note_NoteMeshObject608719166.h"
#include "AssemblyU2DCSharp_PitchName2547986891.h"

#pragma once
// Fretboard/PiecePrefab[]
struct PiecePrefabU5BU5D_t2307676679  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) PiecePrefab_t3531236850  m_Items[1];

public:
	inline PiecePrefab_t3531236850  GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline PiecePrefab_t3531236850 * GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, PiecePrefab_t3531236850  value)
	{
		m_Items[index] = value;
	}
};
// Fretboard/PieceType[]
struct PieceTypeU5BU5D_t1655238457  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline int32_t* GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// Note[,]
struct NoteU5BU2CU5D_t3526180712  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) Note_t2434066 * m_Items[1];

public:
	inline Note_t2434066 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline Note_t2434066 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, Note_t2434066 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Note_t2434066 * GetAt(il2cpp_array_size_t i, il2cpp_array_size_t j) const
	{
		il2cpp_array_size_t index = i * bounds[1].length + j;
		return m_Items[index];
	}
	inline Note_t2434066 ** GetAddressAt(il2cpp_array_size_t i, il2cpp_array_size_t j)
	{
		il2cpp_array_size_t index = i * bounds[1].length + j;
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t i, il2cpp_array_size_t j, Note_t2434066 * value)
	{
		il2cpp_array_size_t index = i * bounds[1].length + j;
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// Note[]
struct NoteU5BU5D_t3526180711  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) Note_t2434066 * m_Items[1];

public:
	inline Note_t2434066 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline Note_t2434066 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, Note_t2434066 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// Note/NoteMeshObject[]
struct NoteMeshObjectU5BU5D_t3956456459  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) NoteMeshObject_t608719166  m_Items[1];

public:
	inline NoteMeshObject_t608719166  GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline NoteMeshObject_t608719166 * GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, NoteMeshObject_t608719166  value)
	{
		m_Items[index] = value;
	}
};
// PitchName[]
struct PitchNameU5BU5D_t4256173738  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline int32_t* GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
