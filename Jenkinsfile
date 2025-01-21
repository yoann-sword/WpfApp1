pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        powershell '\'& "C:\\\\Program Files\\\\Microsoft Visual Studio\\\\2022\\\\Professional\\\\MSBuild\\\\Current\\\\Bin\\\\MSBuild.exe" WpfApp1.sln /p:Configuration=Release\''
        powershell 'mkdir TestResults'
        powershell ' "\'C:\\\\Program Files\\\\Microsoft Visual Studio\\\\2022\\\\Professional\\\\Common7\\\\IDE\\\\Extensions\\\\TestPlatform\\\\vstest.console.exe\'" UnitTestProject1\\\\bin\\\\Release\\\\UnitTestProject1.dll /Logger:trx /ResultsDirectory:TestResults'
      }
    }

  }
}