using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;

        transform.Translate(horizontal, vertical, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
        
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0) 
        { 
            GameObject plant = Instantiate(_plantPrefab, transform.position, transform.rotation) as GameObject;
            plant.gameObject.SetActive(true);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }

    }
}
