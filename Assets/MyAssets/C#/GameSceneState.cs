using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : IState
{
	// === メンバー変数 === //
	SceneManager _SceneManager;
	private GameObject _CubeObj;

	public void Enter()
	{
		Debug.Log($"{GetType().Name} が始まります。");

		_SceneManager = GameObject.FindAnyObjectByType<SceneManager>(); //? SceneManagerを取得

		_CubeObj = GameObject.CreatePrimitive(PrimitiveType.Cube); //? Cubeを生成
	}

	public void Execute()
	{
		Debug.Log($"{GetType().Name} が実行されています。");

		//! マウスの左クリックが押された場合
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			_SceneManager.ChangeScene(new ResultSceneState()); //? ResultSceneStateに遷移
		}
	}

	public void Exit()
	{
		Debug.Log($"{GetType().Name} が終了します。");

		GameObject.Destroy(_CubeObj); //? Cubeを破棄
	}
}
