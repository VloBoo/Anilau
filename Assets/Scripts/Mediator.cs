using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mediator
{
    public static int GameMod = 1;
    public static Player player;
    public static List<Entity> Enemies = new List<Entity>();
    public static Transform CameraTarget;
    public static int score = 0;


    /////////////////////////////
    public static GameObject EndScene;
    public static int Mod;

    public static void GameEnd()
    {
        GameMod = 0;
        Debug.Log("Game Over");
        player.GameObject.transform.position = new Vector3(player.GameObject.transform.position.x, player.GameObject.transform.position.y, -2);
        // EndScene = GameObject.Instantiate(Resources.Load("Prefabs/EndScene") as GameObject);
        EndScene.SetActive(true);
        EndScene.transform.position = new Vector3(player.GameObject.transform.position.x, player.GameObject.transform.position.y, -1);
    }

    public static void Menu()
    {
        EndScene.SetActive(false);
        Application.Quit();

    }
    public static void GameStart()
    {

    }
}
