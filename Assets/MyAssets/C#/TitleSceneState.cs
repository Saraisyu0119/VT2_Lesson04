using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
	// === メンバー変数 === //
	private SceneManager _SceneManager;
	private GameObject _Sphere;

	public void Enter()
	{
		Debug.Log($"{GetType().Name} が始まります。");

		_SceneManager = GameObject.FindAnyObjectByType<SceneManager>(); //? SceneManagerを取得

		_Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); //? Sphereを生成
	}

	public void Execute()
	{
		Debug.Log($"{GetType().Name} が実行されています。");

		//! マウスの左クリックが押された場合
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			_SceneManager.ChangeScene(new GameSceneState()); //? GameSceneStateに遷移
		}
	}

	public void Exit()
	{
		Debug.Log($"{GetType().Name} が終了します。");

		GameObject.Destroy(_Sphere); //? Sphereを破棄
	}
}
