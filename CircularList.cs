using System.Collections;

namespace App092022;

public class CircularList<T> : List<T>, IEnumerable<T> {
    public new IEnumerator<T> GetEnumerator() => new CircularEnumerator<T>(this);

    IEnumerator IEnumerable.GetEnumerator() => new CircularEnumerator<T>(this);
}

internal class CircularEnumerator<T> : IEnumerator<T> {
    private readonly List<T> list;
    private int i;

    public CircularEnumerator(List<T> list) {
        this.list = list;
    }

    public T Current => list[i];

    object IEnumerator.Current => this;

    public void Dispose() {

    }

    public bool MoveNext() {
        i = (i+1) % list.Count;
        return true;
    }

    public void Reset() {
        i = 0;
    }
}