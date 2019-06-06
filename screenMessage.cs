public void Main() {

Runtime.UpdateFrequency = UpdateFrequency.Update100;

Random rnd = new Random(); //random numbers
Random rnd1 = new Random();

String[] textMessageArray = new string[] {"Message1", "Message2", "Message3", "Message4"};
String[] textMessageArray2 = new string[] {"Message1", "Message2" , "Message3"};

int i = rnd.Next(3);
int j = rnd1.Next(2);

var block = GridTerminalSystem.GetBlockWithName("screen1");
var block2 = GridTerminalSystem.GetBlockWithName("screen2");

var surface = block is IMyTextSurface
    ? (IMyTextSurface)block
    : ((IMyTextSurfaceProvider)block).GetSurface(0);

var surface2 = block2 is IMyTextSurface
    ? (IMyTextSurface)block2
    : ((IMyTextSurfaceProvider)block2).GetSurface(0);



surface.WriteText(textMessageArray2[i]);
surface.ContentType = ContentType.TEXT_AND_IMAGE;

surface2.WriteText(textMessageArray[j]);
surface2.ContentType = ContentType.TEXT_AND_IMAGE;

}