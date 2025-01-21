pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'ok2'
        powershell 'bat \'dotnet build WpfApp1.sln\''
      }
    }

  }
}