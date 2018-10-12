﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class AutoLoadAssetWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AutoLoadAsset);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "fileName", _g_get_fileName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loaded", _g_get_loaded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isKeepInMemory", _g_get_isKeepInMemory);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fileName", _s_set_fileName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "loaded", _s_set_loaded);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isKeepInMemory", _s_set_isKeepInMemory);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && translator.Assignable<System.Action>(L, 4))
				{
					string assetName = LuaAPI.lua_tostring(L, 2);
					bool satrtLoad = LuaAPI.lua_toboolean(L, 3);
					System.Action callBack = translator.GetDelegate<System.Action>(L, 4);
					
					AutoLoadAsset __cl_gen_ret = new AutoLoadAsset(assetName, satrtLoad, callBack);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					string assetName = LuaAPI.lua_tostring(L, 2);
					bool satrtLoad = LuaAPI.lua_toboolean(L, 3);
					
					AutoLoadAsset __cl_gen_ret = new AutoLoadAsset(assetName, satrtLoad);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string assetName = LuaAPI.lua_tostring(L, 2);
					
					AutoLoadAsset __cl_gen_ret = new AutoLoadAsset(assetName);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AutoLoadAsset constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action callback = translator.GetDelegate<System.Action>(L, 2);
                    
                    __cl_gen_to_be_invoked.Load( callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fileName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.fileName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loaded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.loaded);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isKeepInMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isKeepInMemory);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fileName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fileName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loaded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.loaded = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isKeepInMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AutoLoadAsset __cl_gen_to_be_invoked = (AutoLoadAsset)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isKeepInMemory = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
