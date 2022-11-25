using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mediator
{
    public static int GameMod = 1;
    public static Player Player;
    public static List<Entity> Enemies = new List<Entity>();
    public static Transform CameraTarget;


    /////////////////////////////
    public static GameObject EndScene;
    public static int Mod;

    public static void GameEnd()
    {
        GameMod = 0;
        Debug.Log("Game Over");
        Player.GameObject.transform.position = new Vector3(Player.GameObject.transform.position.x, Player.GameObject.transform.position.y, -2);
        // EndScene = GameObject.Instantiate(Resources.Load("Prefabs/EndScene") as GameObject);
        EndScene.SetActive(true);
        EndScene.transform.position = new Vector3(Player.GameObject.transform.position.x, Player.GameObject.transform.position.y, -1);
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
