using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using InstantGamesBridge;

public class Ne : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        Bridge.Initialize(isInitialized =>
        {
            if (isInitialized)
            {
                // Готово, можно продолжать. Например, загружать следующую сцену.
            }
            else
            {
                // Ошибка. Что-то пошло не так.
            }
        });
    }

}
