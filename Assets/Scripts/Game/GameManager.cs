using Core;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        private InputManager inputManager;
        private InputData pcData;
        private InputData psData;
        private InputData switchData;
        public RuntimePlatform platform;
        [SerializeField] private bool isKeyboard = true;

        private void Start()
        {
            var path = SetPlatform();
            var asset = Resources.Load("Input/default/" + path);
            var data = (InputData)Instantiate(asset);
            inputManager = new InputManager(data, path);
        }

        private void Update()
        {
            inputManager.Update(Time.deltaTime);
        }

        private string SetPlatform()
        {
            var inputDataPath = "Keyboard";
            if (platform == RuntimePlatform.WindowsPlayer)
            {
                if (isKeyboard)
                {
                    inputDataPath = "Keyboard";
                }
                else
                {
                    inputDataPath = "Controller";
                }
            }
            else if (platform == RuntimePlatform.PS4)
            {
                inputDataPath = "PS";
            }
            else if (platform == RuntimePlatform.Switch)
            {
                inputDataPath = "NS";
            }

            return inputDataPath;
        }
    }
}