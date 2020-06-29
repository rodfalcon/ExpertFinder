import React from 'react';
import { Menu, Container, Button } from 'semantic-ui-react';

interface IProps {
  openCreateForm: () => void;
}

const NavBar: React.FC<IProps> = ({openCreateForm}) => {
  return (
    <Menu fixed='top' inverted>
      <Container>
        <Menu.Item header>
            <img src="/assets/logo.png" alt="logo" style={{marginRight: 10}}/>
            ExpertFinder
        </Menu.Item>
        <Menu.Item name='Specialties' />
        <Menu.Item>
            <Button onClick={openCreateForm} positive content='Create Job Expertise' />
        </Menu.Item>
      </Container>
    </Menu>
  );
};

export default NavBar;
