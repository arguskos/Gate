using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOpener : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;

    public GameObject portal;
    //private float _timer;
    private float TimeToOpen = 20;
    private bool _isOpen = false;
    private bool _isOpening = false;
    private bool _isClosing = false;



    private float _timer;
    public bool Opening = false;
    private float MaxTime=1;
    // Use this for initialization
    public bool GetIsOpen()
    {
        return _isOpen;
    }
    void Start()
    {

        ///StartCoroutine("Open", Color.red);

    }
    public void Open(Color color )
    {
        portal.GetComponent<Renderer>().material.color = color;
        Opening = true;
        

    }
    public void Close()
    {
        Opening = false;
    }
    private void OpenInternal()
    {

        _timer += Time.deltaTime;
        Debug.Log("Open");
        if (_timer < MaxTime)
        {
            part1.GetComponent<Transform>().Translate(Vector3.forward/3 *Time.deltaTime);
            part2.GetComponent<Transform>().Translate(Vector3.forward/3 *Time.deltaTime);
            part3.GetComponent<Transform>().Translate(Vector3.forward/3 *Time.deltaTime);
            part4.GetComponent<Transform>().Translate(Vector3.forward/3 *Time.deltaTime);
        }
        else
        {
            _timer = MaxTime;
        }
    }

    private void CloseIntrnal()
    {

        _timer -= Time.deltaTime;
        if (_timer >0)
        {
            part1.GetComponent<Transform>().Translate(-Vector3.forward / 3 * Time.deltaTime);
            part2.GetComponent<Transform>().Translate(-Vector3.forward / 3 * Time.deltaTime);
            part3.GetComponent<Transform>().Translate(-Vector3.forward / 3 * Time.deltaTime);
            part4.GetComponent<Transform>().Translate(-Vector3.forward / 3 * Time.deltaTime);
        }
        else
        {
            _timer = 0;
        }
    }

    //// Update is called once per frame
    //public IEnumerator Open(Color color)
    //{
    //    if (!_isOpening)
    //    {
    //        portal.GetComponent<Renderer>().material.color = color;
    //        _isOpening = true;
    //        for (float i = 0; i < TimeToOpen; i += 0.1f)
    //        {

    //            part1.GetComponent<Transform>().Translate(Vector3.forward / 444);
    //            part2.GetComponent<Transform>().Translate(Vector3.forward / 444);
    //            part3.GetComponent<Transform>().Translate(Vector3.forward / 444);
    //            part4.GetComponent<Transform>().Translate(Vector3.forward / 444);

    //            yield return null;
    //        }
    //        _isOpen = true;
    //        _isOpening = false;
    //    }
    //    //float _timer = 0;
    //    //Debug.Log("open");
    //    //if (_isOpen)
    //    //    yield return null;
    //    //_timer += Time.deltaTime;

    //    //part1.GetComponent<Transform>().Translate(Vector3.forward / 4 * Time.deltaTime);
    //    //part2.GetComponent<Transform>().Translate(Vector3.forward / 4 * Time.deltaTime);
    //    //part3.GetComponent<Transform>().Translate(Vector3.forward / 4 * Time.deltaTime);
    //    //part4.GetComponent<Transform>().Translate(Vector3.forward / 4 * Time.deltaTime);

    //    //if (_timer > TimeToOpen)
    //    //{
    //    //    _isOpen = true;
    //    //    _timer = 0;
    //    //}
    //    //yield return null;

    //}

    //public IEnumerator Close()
    //{

    //    if (!_isClosing)
    //    {
    //        _isClosing = true;

    //        for (float i = 0; i < TimeToOpen; i += 0.1f)
    //        {

    //            part1.GetComponent<Transform>().Translate(-Vector3.forward / 444);
    //            part2.GetComponent<Transform>().Translate(-Vector3.forward / 444);
    //            part3.GetComponent<Transform>().Translate(-Vector3.forward / 444);
    //            part4.GetComponent<Transform>().Translate(-Vector3.forward / 444);

    //            yield return null;
    //        }

    //        _isOpen = false;
    //        _isClosing = false;
    //    }


    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Machinable")
            Destroy(other.gameObject);
    }
    void Update()
    {


        if (Opening)
            OpenInternal();
        else
            CloseIntrnal();
    }
}
