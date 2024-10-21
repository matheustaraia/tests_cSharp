Feature: Tricentis

    @Cenario01
    Scenario: Preencher o formulario da aba Enter Vehicle Data
        Given que eu acesso o site 'http://sampleapp.tricentis.com/101/app.php'
        And clico na opcao Automobile
        And seleciono a opcao 'Volkswagen'
        And digito no campo Engine Performance o valor '300'
        And digito no campo Date of Manufacture '12/28/2023'        
        And seleciono a opcao '5' no campo Number of Seat
        And seleciono a opcao 'Petrol' no campo Fuel Type        
        And digito no campo List Price o valor '5000'        
        And digito no campo Annual Mileage o valor '2300'
        When clico no botao Next
        Then sou redirecionado pra aba Enter Insurant Data


    @Cenario02
    Scenario: Preencher o formulario da aba Enter Insurant Data
        Given que eu estou na aba Enter Insurant Data        
        And digito no campo First Name o nome 'Matheus'
        And digito no campo Last Name o sobrenome 'Rodrigues'
        And digito no campo Date of Birth a data '07/09/1982'
        And clico na opcao Male no campo Gender
        And seleciono a opcao 'Brazil' no campo Country
        And digito no campo Zip Code o cep '09050430'
        And no campo City digito 'Santo Andre'
        And no campo Occupation seleciono a opcao 'Employee'
        And seleciono Cliff Diving no campo Hobbies
        When clico em Next
        Then sou redirecionado para a aba Enter Product Data e finalizo o drive
        