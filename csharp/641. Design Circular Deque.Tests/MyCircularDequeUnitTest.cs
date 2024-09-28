namespace _641._Design_Circular_Deque.Tests;

public class MyCircularDequeUnitTest
{
    [Fact]
    public void InsertElements_ShouldInsertElementsCorrectly()
    {
        var myCircularDeque = new MyCircularDeque(3);
        Assert.True(myCircularDeque.InsertLast(1));  // Insert 1
        Assert.True(myCircularDeque.InsertLast(2));  // Insert 2
        Assert.True(myCircularDeque.InsertFront(3)); // Insert 3 in front
        Assert.False(myCircularDeque.InsertFront(4)); // Queue is full, should return False
    }

    [Fact]
    public void GetRear_ShouldReturnCorrectValue()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertLast(1);
        myCircularDeque.InsertLast(2);
        Assert.Equal(2, myCircularDeque.GetRear()); // Rear value should be 2
    }

    [Fact]
    public void IsFull_ShouldReturnTrueWhenFull()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertLast(1);
        myCircularDeque.InsertLast(2);
        myCircularDeque.InsertFront(3);
        Assert.True(myCircularDeque.IsFull()); // Queue should be full
    }

    [Fact]
    public void DeleteLast_ShouldRemoveElementCorrectly()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertLast(1);
        myCircularDeque.InsertLast(2);
        Assert.True(myCircularDeque.DeleteLast()); // Delete last element
    }

    [Fact]
    public void GetFront_ShouldReturnCorrectValue()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertLast(1);
        myCircularDeque.InsertLast(2);
        myCircularDeque.InsertFront(4);
        Assert.Equal(4, myCircularDeque.GetFront()); // Front value should be 4
    }

    [Fact]
    public void InsertLastAndGetFront_ShouldReturnFirstInsertLastValue ()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertLast(1);
        myCircularDeque.InsertLast(2);
        Assert.Equal(1, myCircularDeque.GetFront()); // Queue should be full
    }

    [Fact]
    public void InsertFrontAndGetRear_ShouldReturnLastInsertFrontValue()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertFront(1);
        myCircularDeque.InsertFront(2);
        Assert.Equal(1, myCircularDeque.GetRear()); // Queue should be full
    }

    [Fact]
    public void GetRear_WhenInsertFront3TimesDeleteLast3TimesInsertFront3Times_ShouldReturnFirstInsertFrontValue()
    {
        var myCircularDeque = new MyCircularDeque(3);
        myCircularDeque.InsertFront(1);
        myCircularDeque.InsertFront(2);
        myCircularDeque.InsertFront(3);        
        myCircularDeque.DeleteLast();
        myCircularDeque.DeleteLast();
        myCircularDeque.DeleteLast();
        myCircularDeque.InsertFront(1);
        myCircularDeque.InsertFront(2);
        myCircularDeque.InsertFront(3);
        Assert.Equal(1, myCircularDeque.GetRear()); // Queue should be full
    }
}