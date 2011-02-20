require 'rake'
require 'cucumber'
require 'cucumber/rake/task'
require 'albacore'

task :default => [:msbuild]

task :full => [:msbuild, :acceptance_tests]

desc 'Run acceptance tests'
Cucumber::Rake::Task.new(:acceptance_tests) do |t|  
  t.cucumber_opts = "CucumberBDD.AcceptanceTests --format html > acceptance-tests-results.html "
end 

desc "Building solution"
msbuild do |msb|
  msb.properties :configuration => :Release
  msb.targets :Clean, :Build
  msb.verbosity = 'quiet'
  msb.solution = "CucumberBDD.sln"
end



