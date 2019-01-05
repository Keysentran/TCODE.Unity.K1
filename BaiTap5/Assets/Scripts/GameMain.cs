using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour {

    [SerializeField]
    public Transform _endPoint;

    [SerializeField]
    private Transform _startPoint;

    [SerializeField]
    private GameObject[] _tree;

    [SerializeField]
    private GameObject _clound;

    [SerializeField]
    private float _time = 2f;

    [SerializeField]
    private float _timeMin = 1.5f;

    [SerializeField]
    private float _timeMax = 3f;

    [SerializeField]
    private Text _score;

    [SerializeField]
    private Text _highScore;

    [SerializeField]
    private GameObject _playGame;

    [SerializeField]
    private GameObject _gameOver;

    private float value;

    private int _distance;

    private int _highDistance;

    public static Text score;

    public static Vector2 endPoint;

    public static Vector2 startPoint;

    public static int Phase;

    public enum _phase
    {
        _start,
        _play,
        _gameOver
    };

    private void Awake()
    {
        endPoint = _endPoint.position;
        startPoint = _startPoint.position;
        score = _score;
        Phase = (int)_phase._start;
        _playGame.SetActive(true);
        _gameOver.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (Phase == (int)_phase._start)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Phase = (int)_phase._play;
            }
        }
        if (Phase == (int)_phase._play)
        {
            _playGame.SetActive(false);
            _gameOver.SetActive(false);
            Create();
            GetScore();
        }
        if(Phase == (int)_phase._gameOver)
        {
            _gameOver.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Phase = (int)_phase._start;
                if(_distance > _highDistance)
                {
                    _highScore.text = _distance.ToString();
                    _highDistance = _distance;
                }
                value = 0;
            }
        }
    }

    private void Create()
    {
        if (_time > 0)
        {
            _time -= Time.deltaTime;
            if (_time < 0)
            {
                CreateTree();
                CreateClound();
                ResetAndRandomTime();
            }
        }
    }

    private void GetScore()
    {
        value += 5 * Time.deltaTime;
        _distance = (int)value;
        score.text = _distance.ToString();
    }

    private void ResetAndRandomTime()
    {
        _time = Random.Range(_timeMin, _timeMax);
    }

    private void CreateClound()
    {
        Instantiate(_clound, new Vector2(GameMain.startPoint.x, Random.Range(1f, 3f)), Quaternion.identity);
    }

    private void CreateTree()
    {
        Instantiate(_tree[Random.Range(0, 3)], startPoint, Quaternion.identity);
    }
}
