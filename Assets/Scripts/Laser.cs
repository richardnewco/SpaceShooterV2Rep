﻿using System.Collections;using System.Collections.Generic;using UnityEngine;public class Laser : MonoBehaviour{      [SerializeField]    private float _laserSpeed = 2f;    private int _laserCounter;        // Start is called before the first frame update    void Start()    {          }    // Update is called once per frame    void Update()    {        LaserMovement();           }    private void LaserMovement()     {        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);        //        if (transform.position.y > 8f)        {            if (transform.parent != null)            {                Destroy(transform.parent.gameObject);            }            Destroy(this.gameObject);        }    }}