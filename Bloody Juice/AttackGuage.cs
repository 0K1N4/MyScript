/*=====
<AttackGuage.cs>
└作成者：okugami

＞内容
アタックゲージの制御スクリプト

＞更新履歴
__Y25
_M07
D
8:作成　okugami
=====*/

using UnityEngine;
using UnityEngine.UI;

public class AttackGuage : MonoBehaviour
{
    [SerializeField] private Slider m_Slider;

    private const float m_CoolDown = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetCooldown(float max)
    {
        m_Slider.value = m_CoolDown;
    }

    // Update is called once per frame
    public void UpdateGuage(float elapsed)
    {
        m_Slider.value = Mathf.Clamp(elapsed, 0f, m_CoolDown);
    }

    public void ResetGauge()
    {
        m_Slider.value = 0f; // 攻撃直後に0にリセット
    }

}
