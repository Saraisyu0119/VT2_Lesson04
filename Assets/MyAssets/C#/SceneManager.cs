using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // === メンバー変数 === //
    private IState _CurrentSceneState;  //現在のシーン状態を保持する変数

	void Start()
    {
		DontDestroyOnLoad(this.gameObject);  //シーンが切り替わっても破棄されないようにする)
		_CurrentSceneState = new TitleSceneState();  //初期状態をタイトルシーンに設定
		_CurrentSceneState.Enter();
	}

    void Update()
    {
		_CurrentSceneState.Execute();
    }

    //! シーンを切り替える処理
    public void ChangeScene(IState nextSceneState)
    {
		_CurrentSceneState.Exit(); //? 現在のシーンを終了。
		_CurrentSceneState = nextSceneState; //? 現在のシーン状態を次のシーン状態に変更。
		_CurrentSceneState.Enter(); //? 次のシーンを開始。
	}
}