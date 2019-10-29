using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIAchievementListItem : VirtualListItem
{
    public Text m_TxtName;

    public Button m_Btn;

    private void Awake()
    {
        m_TxtName = transform.Find("Text").GetComponent<Text>();
        m_Btn = GetComponent<Button>();
    }

    protected override void OnRenderer()
    {
        base.OnRenderer();
        int index = (int)mData + 1;
        m_TxtName.text = string.Format("先定他个小目标，赚他{0}个亿", index);
    }
}
