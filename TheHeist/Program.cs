// See https://aka.ms/new-console-template for more information
using TheHeist;
using TheHeist.Models;


var title = $@"
 _______   __         ______   __    __        __      __   ______   __    __  _______         __    __  ________  ______   ______  ________ 
|       \ |  \       /      \ |  \  |  \      |  \    /  \ /      \ |  \  |  \|       \       |  \  |  \|        \|      \ /      \|        \
| $$$$$$$\| $$      |  $$$$$$\| $$\ | $$       \$$\  /  $$|  $$$$$$\| $$  | $$| $$$$$$$\      | $$  | $$| $$$$$$$$ \$$$$$$|  $$$$$$\\$$$$$$$$
| $$__/ $$| $$      | $$__| $$| $$$\| $$        \$$\/  $$ | $$  | $$| $$  | $$| $$__| $$      | $$__| $$| $$__      | $$  | $$___\$$  | $$   
| $$    $$| $$      | $$    $$| $$$$\ $$         \$$  $$  | $$  | $$| $$  | $$| $$    $$      | $$    $$| $$  \     | $$   \$$    \   | $$   
| $$$$$$$ | $$      | $$$$$$$$| $$\$$ $$          \$$$$   | $$  | $$| $$  | $$| $$$$$$$\      | $$$$$$$$| $$$$$     | $$   _\$$$$$$\  | $$   
| $$      | $$_____ | $$  | $$| $$ \$$$$          | $$    | $$__/ $$| $$__/ $$| $$  | $$      | $$  | $$| $$_____  _| $$_ |  \__| $$  | $$   
| $$      | $$     \| $$  | $$| $$  \$$$          | $$     \$$    $$ \$$    $$| $$  | $$      | $$  | $$| $$     \|   $$ \ \$$    $$  | $$   
 \$$       \$$$$$$$$ \$$   \$$ \$$   \$$           \$$      \$$$$$$   \$$$$$$  \$$   \$$       \$$   \$$ \$$$$$$$$ \$$$$$$  \$$$$$$    \$$   
                                                                                                                                             
                                                                                                                                             
                                                                                                                                             ";

Console.WriteLine(title);
var heist = new HeistSimulator();
heist.DetermineHeistDifficulty();
heist.CreateTeam();
heist.DetermineNumberOfTests();
heist.ShowResults();







//Build Team
//List<TeamMember> teamMembers = new List<TeamMember>();
//var factory = new TeamMemberFactory();
//var buildingTeam = true;
//Console.Clear();
//var teamMemberCountText = $"There {(teamMembers.Count == 1 ? "is" : "are")} {teamMembers.Count} team {(teamMembers.Count == 1 ? "member" : "members")}.";




////for loop - do something a certain number of times
//for (int i = 0; i < length; i++)
//{

//}

////foreach - same as FOR but specifically loops over a collection
//foreach (var item in collection)
//{

//}

////while - loop UNTIL something specific happens
//while (true)
//{

//}


//display result for each heist


//if (sum >= bankDifficulty)
//{
//    //DisplaySuccess();
//    Console.WriteLine("The heist was successful!");
//}
//else
//{
//    //DisplayFailure();
//    Console.WriteLine("The heist was a failure!");
//}

//Console.WriteLine(teamMemberCountText);
//foreach (TeamMember member in teamMembers)
//{
//    Console.WriteLine(member.ToString());
//}
