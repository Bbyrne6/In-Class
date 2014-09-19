using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Requirments.UserStories
{
    [story(AsA="Resturaunt manager",
Iwant="To manage my waiters",
SoThat="I have enough staff to wait on tables",
)]

}
public class ManageWairersStory
{
[fact]
[AutoRollback]
public void AddWaitersScenerio() 
{
	Waiter newGuy = new Waiter();
int waiterId = -1;
	this.Given(_=>GiveWaiterInformation(newGuy))
.when(_=>WhenIAddTheWaiter(newGuy, out waitId))
.then(_=>ThenTheWaiterExists(waiterId))
.And(_=>TheWaiterDetailsMatch(waiterId, newGuy))
.BDDfy

private object TheWaiterDetailsMatch(int waiterId,Waiter newGuy)
{
 	throw new NotImplementedException();
}

private object ThenTheWaiterExists(int waiterId)
{
 	throw new NotImplementedException();
}

private object GiveWaiterInformation(Waiter newGuy)
{
 	throw new NotImplementedException();
} ManageWaitersStory
    {
    }
}
