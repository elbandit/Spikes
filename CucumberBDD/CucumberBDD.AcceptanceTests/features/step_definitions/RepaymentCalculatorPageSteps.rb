require 'rspec'
require 'watir' 
include Watir

Before do |scenario|
   BROWSER = Watir::IE.new
end

Given /^I am on the loan repayment calculator page$/ do
  BROWSER.goto("http://localhost:40233/")
end

Given /^that I have entered a loan amount of "([^"]*)"$/ do |arg1|
  BROWSER.text_field(:name, "LoanAmount").set(arg1)
end

Given /^a repayment term of "([^"]*)" years$/ do |arg1|
  BROWSER.text_field(:name, "RepaymentTerm").set(arg1)
end

Given /^an interest rate of "([^"]*)"%$/ do |arg1|
  BROWSER.text_field(:name, "InterestRate").set(arg1)
end

When /^I click the calculate monthly repayment button$/ do
  BROWSER.button(:id, "bCalcRepayments").click
end

Then /^I will be shown a monthly repayment of "([^"]*)"$/ do |arg1|
  BROWSER.div(:id, "MonthlyRepaymentAmount").text.should == "1767.99"
end

After do |scenario|
  BROWSER.close
end
