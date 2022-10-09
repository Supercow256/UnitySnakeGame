using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeMovement : MonoBehaviour
{

    private Vector2 _direction = Vector2.right;

    private List<Transform> _segments = new List<Transform>();

    public Transform SnakeSectionPreFab;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("StartScreen");
        //PlayerPrefs.SetInt("InitialSnakeSize", initialSize);

        ResetGame();
    }
   

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && _direction != Vector2.down)
        {
            _direction = Vector2.up;
        }
        else if ((Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && _direction != Vector2.right)
        {
            _direction = Vector2.left;
        }
        else if ((Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && _direction != Vector2.up)
        {
            _direction = Vector2.down;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && _direction != Vector2.left)
        {
            _direction = Vector2.right;
        }

    }

    private void FixedUpdate()
    {
        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3(
            Mathf.Round( this.transform.position.x) + _direction.x,
            Mathf.Round( this.transform.position.y) + _direction.y,
            0.0f
            );
        /*
        for (int i = 0; i < _segments.Count - 1; i++);
        {
            _segment[i].transform.position = new Vector3(
                Mathf.Round(this.transform.position.x) + _direction.x - 10,
            Mathf.Round(this.transform.position.y) + _direction.y - 10,
            0.0f
            );
        }
        */  
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.SnakeSectionPreFab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);
        GlobalVars.foodEaten++;
    }

    private void ResetGame()
    {
        /*
        for (int i = 1; i < _segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);
        }
            _segments.Clear();
            _segments.Add(this.transform);

            this.transform.position = Vector3.zero;
        */
        GlobalVars.foodEaten = 0;
        for (int i = _segments.Count - 1; i > GlobalVars.initSize; i--)
        {
            //Destroys the object in that index
            Destroy(_segments[i].gameObject);

        }   
            // _segment.Clear(); clears the list and destroys all of the index's where there was no object
            _segments.Clear();
            _segments.Add(this.transform);
        // sets snake to initial size
        for (int i = 1; i < GlobalVars.initSize; i++)
        {
            Grow();
        }
        //sets snake back to (0.0f, 0.0f, 0.0f)
        this.transform.position = Vector3.zero;
        
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
        }
        else if (other.tag == "Wall" || other.tag == "Player")
        {
            FindObjectOfType<GameController>().EndGame();
            //ResetGame();
        
        }
    }
}
