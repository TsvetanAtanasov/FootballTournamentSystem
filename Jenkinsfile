pipeline {
  agent any
    stage('Docker Build') {
      steps {  
        powershell(script: 'docker-compose build') 
        powershell(script: 'docker images -a')
      }
    }
}