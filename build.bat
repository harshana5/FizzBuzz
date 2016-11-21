_nuget\nuget.exe restore FizzBuzz.sln

call bootstrap.bat
_powerup\build\nant\nant\bin\nant -D:solution.name=FizzBuzz %*
