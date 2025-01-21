pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'ok2'
        powershell '\'& "C:\\\\Program Files\\\\Microsoft Visual Studio\\\\2022\\\\Professional\\\\MSBuild\\\\Current\\\\Bin\\\\MSBuild.exe" WpfApp1.sln /p:Configuration=Release\''
      }
    }

  }
}