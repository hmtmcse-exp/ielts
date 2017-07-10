@translate

Feature: Testing Google Translate


  Scenario Outline:
    Given open the url
    When select from english language
    Then select to bangla language
    And put the <word> to input box
    Then press translate button
    Then save the <word> result

    Examples:
    |word|
    |visual|
    |symbols|
    |blind|