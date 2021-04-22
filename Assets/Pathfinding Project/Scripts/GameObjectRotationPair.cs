using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectRotationPair
{
    public GameObject gameObject;
    public Vector3 rotation = Vector3.zero;
    public GameObjectRotationPair(GameObject _gameObject, Vector3 _rotation)
    {
        gameObject = _gameObject;
        rotation = _rotation;
    }
    public GameObjectRotationPair(GameObject _gameObject) => gameObject = _gameObject;
}
