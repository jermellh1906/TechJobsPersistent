--Part 1
show columns from jobs;

--Part 2
select Name from employers
where Location = 'St. Louis';

--Part 3
select Name, Description
from jobskills inner join skills on SkillId = Id
order by Name;
