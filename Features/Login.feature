Feature: OrangeHRM

  Scenario: Update user role in OrangeHRM
    Given I open the OrangeHRM page
    When I login with username and password 
    And I navigate to the Admin page
    And I edit the second record
    And I update the user role
    Then the user role should be updated for the second record
