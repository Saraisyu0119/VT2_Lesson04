using UnityEngine;
using UnityEngine.InputSystem;

public class ResultSceneState : IState
{
	// === メンバー変数 === //
	SceneManager _SceneManager;
	GameObject _CapsuleObj;

	public void Enter()
	{
		Debug.Log($"{GetType().Name} が始まります。");

		_SceneManager = GameObject.FindAnyObjectByType<SceneManager>(); //? SceneManagerを取得

		_CapsuleObj = GameObject.CreatePrimitive(PrimitiveType.Capsule); //? Capsuleを生成
	}

	public void Execute()
	{
		Debug.Log($"{GetType().Name} が実行されています。");

		//! マウスの左クリックが押された場合
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			_SceneManager.ChangeScene(new TitleSceneState()); //? TitleSceneStateに遷移
		}
	}

	public void Exit()
	{
		Debug.Log($"{GetType().Name} が終了します。");

		GameObject.Destroy(_CapsuleObj); //? Capsuleを破棄
	}
}
