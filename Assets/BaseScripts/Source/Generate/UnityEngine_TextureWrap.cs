﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TextureWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Texture), typeof(UnityEngine.Object));
		L.RegFunction("IncrementUpdateCount", IncrementUpdateCount);
		L.RegFunction("SetGlobalAnisotropicFilteringLimits", SetGlobalAnisotropicFilteringLimits);
		L.RegFunction("GetNativeTexturePtr", GetNativeTexturePtr);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("updateCount", get_updateCount, null);
		L.RegFunction("getupdateCount", get_updateCount);
		L.RegVar("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit);
		L.RegFunction("getmasterTextureLimit", get_masterTextureLimit);
		L.RegFunction("setmasterTextureLimit", set_masterTextureLimitter);
		L.RegVar("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
		L.RegFunction("getanisotropicFiltering", get_anisotropicFiltering);
		L.RegFunction("setanisotropicFiltering", set_anisotropicFilteringter);
		L.RegVar("width", get_width, set_width);
		L.RegFunction("getwidth", get_width);
		L.RegFunction("setwidth", set_width);
		L.RegVar("height", get_height, set_height);
		L.RegFunction("getheight", get_height);
		L.RegFunction("setheight", set_height);
		L.RegVar("dimension", get_dimension, set_dimension);
		L.RegFunction("getdimension", get_dimension);
		L.RegFunction("setdimension", set_dimension);
		L.RegVar("wrapMode", get_wrapMode, set_wrapMode);
		L.RegFunction("getwrapMode", get_wrapMode);
		L.RegFunction("setwrapMode", set_wrapMode);
		L.RegVar("wrapModeU", get_wrapModeU, set_wrapModeU);
		L.RegFunction("getwrapModeU", get_wrapModeU);
		L.RegFunction("setwrapModeU", set_wrapModeU);
		L.RegVar("wrapModeV", get_wrapModeV, set_wrapModeV);
		L.RegFunction("getwrapModeV", get_wrapModeV);
		L.RegFunction("setwrapModeV", set_wrapModeV);
		L.RegVar("wrapModeW", get_wrapModeW, set_wrapModeW);
		L.RegFunction("getwrapModeW", get_wrapModeW);
		L.RegFunction("setwrapModeW", set_wrapModeW);
		L.RegVar("filterMode", get_filterMode, set_filterMode);
		L.RegFunction("getfilterMode", get_filterMode);
		L.RegFunction("setfilterMode", set_filterMode);
		L.RegVar("anisoLevel", get_anisoLevel, set_anisoLevel);
		L.RegFunction("getanisoLevel", get_anisoLevel);
		L.RegFunction("setanisoLevel", set_anisoLevel);
		L.RegVar("mipMapBias", get_mipMapBias, set_mipMapBias);
		L.RegFunction("getmipMapBias", get_mipMapBias);
		L.RegFunction("setmipMapBias", set_mipMapBias);
		L.RegVar("texelSize", get_texelSize, null);
		L.RegFunction("gettexelSize", get_texelSize);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IncrementUpdateCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)ToLua.CheckObject<UnityEngine.Texture>(L, 1);
			obj.IncrementUpdateCount();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalAnisotropicFilteringLimits(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNativeTexturePtr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)ToLua.CheckObject<UnityEngine.Texture>(L, 1);
			System.IntPtr o = obj.GetNativeTexturePtr();
			LuaDLL.lua_pushlightuserdata(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			uint ret = obj.updateCount;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updateCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_masterTextureLimit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Texture.masterTextureLimit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.Texture.anisotropicFiltering);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.width;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.height;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dimension(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.Rendering.TextureDimension ret = obj.dimension;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dimension on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode ret = obj.wrapMode;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeU(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode ret = obj.wrapModeU;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeU on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeV(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode ret = obj.wrapModeV;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeV on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeW(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode ret = obj.wrapModeW;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeW on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_filterMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.FilterMode ret = obj.filterMode;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index filterMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisoLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.anisoLevel;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index anisoLevel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mipMapBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			float ret = obj.mipMapBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mipMapBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_texelSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.Vector2 ret = obj.texelSize;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index texelSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimit(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Texture.masterTextureLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimitter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Texture.masterTextureLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Texture.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFilteringter(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Texture.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.width = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dimension(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.Rendering.TextureDimension arg0 = (UnityEngine.Rendering.TextureDimension)LuaDLL.luaL_checknumber(L, 2);
			obj.dimension = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dimension on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode arg0 = (UnityEngine.TextureWrapMode)LuaDLL.luaL_checknumber(L, 2);
			obj.wrapMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeU(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode arg0 = (UnityEngine.TextureWrapMode)LuaDLL.luaL_checknumber(L, 2);
			obj.wrapModeU = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeU on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeV(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode arg0 = (UnityEngine.TextureWrapMode)LuaDLL.luaL_checknumber(L, 2);
			obj.wrapModeV = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeV on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeW(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode arg0 = (UnityEngine.TextureWrapMode)LuaDLL.luaL_checknumber(L, 2);
			obj.wrapModeW = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapModeW on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_filterMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.FilterMode arg0 = (UnityEngine.FilterMode)LuaDLL.luaL_checknumber(L, 2);
			obj.filterMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index filterMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisoLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.anisoLevel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index anisoLevel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mipMapBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mipMapBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mipMapBias on a nil value");
		}
	}
}
