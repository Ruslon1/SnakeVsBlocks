using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class TailGenerator : MonoBehaviour
{
    [SerializeField] private Segment _segmentTemplate;

    public List<Segment> Generate(int count)
    {
        List<Segment> tail = new List<Segment>();

        for (int i = 0; i < count; i++)
        {
            tail.Add(Instantiate(_segmentTemplate, transform));
        }

        return tail;
    }
}