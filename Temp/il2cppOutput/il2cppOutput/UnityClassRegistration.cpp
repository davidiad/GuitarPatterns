struct ClassRegistrationContext;
void InvokeRegisterStaticallyLinkedModuleClasses(ClassRegistrationContext& context)
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

}

void RegisterAllClasses()
{
	//Total: 59 classes
	//0. Renderer
	void RegisterClass_Renderer();
	RegisterClass_Renderer();

	//1. Component
	void RegisterClass_Component();
	RegisterClass_Component();

	//2. EditorExtension
	void RegisterClass_EditorExtension();
	RegisterClass_EditorExtension();

	//3. GUILayer
	void RegisterClass_GUILayer();
	RegisterClass_GUILayer();

	//4. Behaviour
	void RegisterClass_Behaviour();
	RegisterClass_Behaviour();

	//5. Texture
	void RegisterClass_Texture();
	RegisterClass_Texture();

	//6. NamedObject
	void RegisterClass_NamedObject();
	RegisterClass_NamedObject();

	//7. Texture2D
	void RegisterClass_Texture2D();
	RegisterClass_Texture2D();

	//8. NetworkView
	void RegisterClass_NetworkView();
	RegisterClass_NetworkView();

	//9. RectTransform
	void RegisterClass_RectTransform();
	RegisterClass_RectTransform();

	//10. Transform
	void RegisterClass_Transform();
	RegisterClass_Transform();

	//11. Shader
	void RegisterClass_Shader();
	RegisterClass_Shader();

	//12. TextAsset
	void RegisterClass_TextAsset();
	RegisterClass_TextAsset();

	//13. Material
	void RegisterClass_Material();
	RegisterClass_Material();

	//14. Camera
	void RegisterClass_Camera();
	RegisterClass_Camera();

	//15. MonoBehaviour
	void RegisterClass_MonoBehaviour();
	RegisterClass_MonoBehaviour();

	//16. GameObject
	void RegisterClass_GameObject();
	RegisterClass_GameObject();

	//17. Collider
	void RegisterClass_Collider();
	RegisterClass_Collider();

	//18. AudioClip
	void RegisterClass_AudioClip();
	RegisterClass_AudioClip();

	//19. SampleClip
	void RegisterClass_SampleClip();
	RegisterClass_SampleClip();

	//20. AudioSource
	void RegisterClass_AudioSource();
	RegisterClass_AudioSource();

	//21. AudioBehaviour
	void RegisterClass_AudioBehaviour();
	RegisterClass_AudioBehaviour();

	//22. TextMesh
	void RegisterClass_TextMesh();
	RegisterClass_TextMesh();

	//23. Font
	void RegisterClass_Font();
	RegisterClass_Font();

	//24. PreloadData
	void RegisterClass_PreloadData();
	RegisterClass_PreloadData();

	//25. Cubemap
	void RegisterClass_Cubemap();
	RegisterClass_Cubemap();

	//26. Texture3D
	void RegisterClass_Texture3D();
	RegisterClass_Texture3D();

	//27. RenderTexture
	void RegisterClass_RenderTexture();
	RegisterClass_RenderTexture();

	//28. Mesh
	void RegisterClass_Mesh();
	RegisterClass_Mesh();

	//29. LevelGameManager
	void RegisterClass_LevelGameManager();
	RegisterClass_LevelGameManager();

	//30. GameManager
	void RegisterClass_GameManager();
	RegisterClass_GameManager();

	//31. TimeManager
	void RegisterClass_TimeManager();
	RegisterClass_TimeManager();

	//32. GlobalGameManager
	void RegisterClass_GlobalGameManager();
	RegisterClass_GlobalGameManager();

	//33. AudioManager
	void RegisterClass_AudioManager();
	RegisterClass_AudioManager();

	//34. InputManager
	void RegisterClass_InputManager();
	RegisterClass_InputManager();

	//35. MeshRenderer
	void RegisterClass_MeshRenderer();
	RegisterClass_MeshRenderer();

	//36. GraphicsSettings
	void RegisterClass_GraphicsSettings();
	RegisterClass_GraphicsSettings();

	//37. MeshFilter
	void RegisterClass_MeshFilter();
	RegisterClass_MeshFilter();

	//38. QualitySettings
	void RegisterClass_QualitySettings();
	RegisterClass_QualitySettings();

	//39. PhysicsManager
	void RegisterClass_PhysicsManager();
	RegisterClass_PhysicsManager();

	//40. MeshCollider
	void RegisterClass_MeshCollider();
	RegisterClass_MeshCollider();

	//41. BoxCollider
	void RegisterClass_BoxCollider();
	RegisterClass_BoxCollider();

	//42. TagManager
	void RegisterClass_TagManager();
	RegisterClass_TagManager();

	//43. AudioListener
	void RegisterClass_AudioListener();
	RegisterClass_AudioListener();

	//44. ScriptMapper
	void RegisterClass_ScriptMapper();
	RegisterClass_ScriptMapper();

	//45. DelayedCallManager
	void RegisterClass_DelayedCallManager();
	RegisterClass_DelayedCallManager();

	//46. RenderSettings
	void RegisterClass_RenderSettings();
	RegisterClass_RenderSettings();

	//47. Light
	void RegisterClass_Light();
	RegisterClass_Light();

	//48. MonoScript
	void RegisterClass_MonoScript();
	RegisterClass_MonoScript();

	//49. MonoManager
	void RegisterClass_MonoManager();
	RegisterClass_MonoManager();

	//50. FlareLayer
	void RegisterClass_FlareLayer();
	RegisterClass_FlareLayer();

	//51. PlayerSettings
	void RegisterClass_PlayerSettings();
	RegisterClass_PlayerSettings();

	//52. BuildSettings
	void RegisterClass_BuildSettings();
	RegisterClass_BuildSettings();

	//53. ResourceManager
	void RegisterClass_ResourceManager();
	RegisterClass_ResourceManager();

	//54. NetworkManager
	void RegisterClass_NetworkManager();
	RegisterClass_NetworkManager();

	//55. MasterServerInterface
	void RegisterClass_MasterServerInterface();
	RegisterClass_MasterServerInterface();

	//56. LightmapSettings
	void RegisterClass_LightmapSettings();
	RegisterClass_LightmapSettings();

	//57. LightProbes
	void RegisterClass_LightProbes();
	RegisterClass_LightProbes();

	//58. RuntimeInitializeOnLoadManager
	void RegisterClass_RuntimeInitializeOnLoadManager();
	RegisterClass_RuntimeInitializeOnLoadManager();

}
