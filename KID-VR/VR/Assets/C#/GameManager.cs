using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool havekey;

    //公開並且參數零或一個
    public void ThrowPickUp()
    {
        print("撿起物件");
    }

    public void ThrowDetach(GameObject obj)
    {
        print("放開物件");
        havekey = true;
        Destroy(obj);
    }

    public void ThrowHeld()
    {
        print("拿著物件");
    }

    //重新開始
    public void Replay()
    {
        SceneManager.LoadScene("VR 場景");
    }
   

    //離開遊戲
    public void Quit()
    {
        Application.Quit();
    }

}
