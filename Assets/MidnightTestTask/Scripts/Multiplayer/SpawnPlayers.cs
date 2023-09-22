using System;
using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MidnightTestTask.Scripts.Multiplayer
{
    public class SpawnPlayers : MonoBehaviour
    {
        [SerializeField] private GameObject _carPrefab;
        
        [SerializeField] private float _minZ;
        [SerializeField] private float _maxZ;


        private void Start()
        {
            Vector3 randomPosition = new Vector3(_carPrefab.transform.position.x, _carPrefab.transform.position.y, Random.Range(_minZ, _maxZ));
            PhotonNetwork.Instantiate(_carPrefab.name, randomPosition, _carPrefab.transform.rotation);
        }
    }
}
