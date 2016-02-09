In order to run tests:

1. Load the Halso_Hub project into a sulotion.
2. Add a new test project into the SAME sulotion with the name Halso_Hub_Tests.
3. Import the test files into Halso_Hub_Tests.
4. Add a references in Halso_Hub_Tests to Halso_Hub
5. Modify Halso_Hub -> Properties -> AssemblyInfo.cs to include [assembly: InternalsVisibleTo("Halso_Hub_Tests")]
6. In the visual studio menu: Tests -> Windows -> Test Explorer
7. In the Test Explorer press "Run All"