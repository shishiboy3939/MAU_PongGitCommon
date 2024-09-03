using UnityEngine;

public class AnimatorController: MonoBehaviour
{
    //-----------------------------------------------------------------------
    // メンバ変数
    //-----------------------------------------------------------------------

    // アニメーター
    private Animator m_Animator = null;

    //-----------------------------------------------------------------------
    // クラス取得
    public Player1  player1;
    public Player2 player2;
    //-----------------------------------------------------------------------

    // 初期化処理
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void VerticalDirection(){
        m_Animator.SetBool("Bool",true);
    }
    public void HorizontalDirection(){
        m_Animator.SetBool("Bool",false);
    }


}
