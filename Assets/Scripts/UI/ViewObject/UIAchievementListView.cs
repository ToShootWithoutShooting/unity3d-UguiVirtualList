using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Demo
{
    public class UIAchievementListView : MonoBehaviour
    {
        private VirtualListView m_Achievement_List;  //成就列表
        private Button m_CloseBtn;

        [UnityEngine.Header("子组件个数")]
        public int NumItems;

        private void Start()
        {
            Transform transf = transform.Find("ScrollRectPanel/ListPanel");

            m_Achievement_List = transf.GetComponent<VirtualListView>();
            m_Achievement_List.NumItems = NumItems;   //设置子item数目
        }
        
    }
}