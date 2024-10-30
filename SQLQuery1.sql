INSERT INTO TeamMembers(PhotoPath, Name, Surname, Position, CreatedAt)
VALUES
('/assets/img/team-01.jpg', 'John', 'Doe', 'Business Development', GETDATE()),
('/assets/img/team-02.jpg', 'Jane', 'Doe', 'Media Development', GETDATE()),
('/assets/img/team-03.jpg', 'Rasim', NULL, 'Developer', GETDATE())

INSERT INTO RecentWorks(PhotoPath, Title, Description, CreatedAt)
VALUES
('/assets/img/recent-work-01.jpg', 'Social Media', 'Ullamco laboris nisi ut aliquip ex', GETDATE()),
('/assets/img/recent-work-02.jpg', 'Web Marketing', 'Psum officia anim id est laborum.', GETDATE()),
('/assets/img/recent-work-03.jpg', 'R & D', 'Sum dolor sit consencutur', GETDATE()),
('/assets/img/recent-work-04.jpg', 'Public Relation', 'Lorem ipsum dolor sit amet', GETDATE()),
('/assets/img/recent-work-05.jpg', 'Branding', 'Put enim ad minim veniam', GETDATE()),
('/assets/img/recent-work-06.jpg', 'Creative Design', 'Mollit anim id est laborum.', GETDATE())

INSERT INTO Aims(Title, Description, CreatedAt)
VALUES
('Our Vision', 'Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra.', GETDATE()),
('Our Mission', ' Eiusmod tempor incididunt ut labore et dolore magna aliqua.
 Ut enim ad minim veniam quis.', GETDATE()),
('Our Goal', ' Lorem ipsum dolor sit amet, consectetur adipisicing elit,
 sed do eiusmod tempor.', GETDATE())


INSERT INTO PricingPlans(PlanName, Price, Users, Space, Sources, Support, AdditionalFeature, CreatedAt)
VALUES 
('Free', 0, '5 Users', '2 TB space', 'Community Forums', 'Email Support', NULL, GETDATE()),
('Standart', 120, '25 to 99 Users', '10 TB space', 'Source Files', 'Live Chat', NULL, GETDATE()),
('Enterprise', 840, '100 users or more', '80 TB space', 'Full Access Sources', 'Live Chat', 'Customizations', GETDATE())

INSERT INTO ContactInfos(ContactType, Name, Surname, PhoneNumber, CreatedAt)
VALUES
('Media Contact', 'John', 'Doe', '010-020-0340', GETDATE()),
('Technical Contact', 'John', 'Stiles', '010-020-0340', GETDATE()),
('Billing Contact', 'Richard', 'Miles', '010-020-0340', GETDATE())
