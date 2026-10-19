using UnityEngine;

/// <summary>
/// インターフェース(interface)
///	?インターフェースを継承するクラスは、記述されているメソッドやプロパティをすべて実装しないとエラーになる。
/// </summary>

public interface IState
{
	void Enter();		//初期化処理
	void Execute();		//更新処理
	void Exit();			//終了処理
}
