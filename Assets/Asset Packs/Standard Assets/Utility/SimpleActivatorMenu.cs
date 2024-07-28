using UnityEngine;
using UnityEngine.UI; // Import the UI namespace

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        public Text camSwitchButtonText; // Change to Text instead of GUIText
        public GameObject[] objects;

        private int m_CurrentActiveObject;

        private void OnEnable()
        {
            m_CurrentActiveObject = 0;
            if (camSwitchButtonText != null && objects.Length > 0)
            {
                camSwitchButtonText.text = objects[m_CurrentActiveObject].name;
            }
        }

        public void NextCamera()
        {
            int nextActiveObject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextActiveObject);
            }

            m_CurrentActiveObject = nextActiveObject;
            if (camSwitchButtonText != null && objects.Length > 0)
            {
                camSwitchButtonText.text = objects[m_CurrentActiveObject].name;
            }
        }
    }
}
